using Islem;

namespace Lokanta2
{
    public partial class AnaForm : Form
    {
        //Ýþ yapan sýnýflarý new ile türetmek formun bu sýnýflara baðýmlý olmasýna sebep olur
        //sýnýflarýn yapýcý metodundaki bir deðiþmden bu form etkilenir
        //Sýnýf üretme iþini bu form içinden alýp kütüphanedeki baþka bir üretici sýnýfa verebiliri
        //Bu yönteme Factory tasarým deseni denir.
        YemekIslem yemekIslem = Fabrika.IslemNesnesiGetir<YemekIslem>();//new YemekIslem();
        SiparisIslem si = Fabrika.IslemNesnesiGetir<SiparisIslem>();
        OturumIslem OturumIslem = Fabrika.IslemNesnesiGetir<OturumIslem>();
        
        List<Islem.Models.Todo> isListesi = new List<Islem.Models.Todo>();
        List<Islem.Models.user> userListe = new List<Islem.Models.user>();

        ILog _log;
        public AnaForm()
        {
             yemekIslem = Fabrika.IslemNesnesiGetir<YemekIslem>();//new YemekIslem();
             si = Fabrika.IslemNesnesiGetir<SiparisIslem>();
             OturumIslem = Fabrika.IslemNesnesiGetir<OturumIslem>();
            _log = Fabrika.LogNesnesiGetir();
            if (Islem.Models.Oturum.AcikMi==null || Islem.Models.Oturum.AcikMi==false)
            {
                GirisForm girisForm = new GirisForm();
                girisForm.ShowDialog();
            }
            InitializeComponent();
        }

        public void AnaFormYukle()
        {
            SiparisIslem islem = new SiparisIslem();
            var masaListe = islem.MasaListesiGetir();
            int x = 100;
            int y = 100;
            flpMasabutonListe.Controls.Clear();
            ///Bu döngü ile kaç tane masa varsa o kadar buton form üzerine eklenecektir
            foreach (var siradakiMasa in masaListe)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                //btn.Location = new Point(x, y);
                btn.Text = siradakiMasa.Ad;
                btn.Tag = siradakiMasa.Id;
                btn.BackColor = Color.DarkRed;
                btn.ForeColor = Color.White;
                btn.Click += new EventHandler(masaButton_Click);
                flpMasabutonListe.Controls.Add(btn);
                if (siradakiMasa.Siparis.Count > 0)
                {
                    btn.BackColor = Color.SkyBlue;

                }
                if (Islem.Models.Oturum.AcikMi == true)
                {
                    lblOturumAd.Text = Islem.Models.Oturum.Ad;
                }
                else
                {
                    btnOturumKapat.Visible = false;
                }
                //this.Controls.Add(btn);
                //tpSiparis.Controls.Add(btn);
                //if (Islem.Models.Oturum.AcikMi==true)
                //{
                //    kullaniciOturum_uc.Ad = Islem.Models.Oturum.Ad;
                //    kullaniciOturum_uc.Soyad = Islem.Models.Oturum.Soyad;
                //    kullaniciOturum_uc.KayitTarihi = Islem.Models.Oturum.KayitTarihi;
                //    kullaniciOturum_uc.Cinsiyet = Islem.Models.Oturum.Cinsiyet;
                    
                //}

            }
        }
        private int SecilenMasaId { get; set; }
        private void Siparis_Load(object sender, EventArgs e)
        {
            AnaFormYukle();
        }

        /// <summary>
        /// Bir olaya baðalanabilecek bir metot yazdýk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void masaButton_Click(object sender, EventArgs e)
        {
            //foreach (var eleman in this.Controls)
            //{
            //    if (eleman is Button)
            //    {
            //        var btn = eleman as Button;
            //        btn.BackColor = Color.DarkRed;
            //        btn.ForeColor = Color.White;
            //    }
            //}

            //tiklananButon.BackColor = Color.SkyBlue;

            //Islem.SiparisIslem islem = new SiparisIslem();
            //lbx_masSiparisListe.DataSource = islem.MasaSiparisGetir(SecilenMasaId);
            Button tiklananButon = sender as Button;
            int masaId = (int)tiklananButon.Tag;
            MasaSaparisForm yeniForm = new MasaSaparisForm(masaId);
            yeniForm.ShowDialog();


            AnaFormYukle();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {

            DataModel.Yemek yeniYemek = Fabrika.EntityGetir<DataModel.Yemek>();
            yeniYemek.Ad = tbYemeAdi.Text;
            yeniYemek.Kalori = Convert.ToInt32(tbKalori.Text);
            yeniYemek.Fiyat = Convert.ToDecimal(tbFiyat.Text);
            yemekIslem.YemekEkle(yeniYemek);
            dgvYemekListe.DataSource = yemekIslem.YemekListesiGetir();

            //Log log = new Log();
            //log.VeritabaniLogEkle("Yeni yemek eklendi");

            _log.LogYaz("Yemek eklendi");
        }

        private void tpYemekYonetim_Enter(object sender, EventArgs e)
        {
            ///sekme açýldýðýnda yapýlacak iþlemler

            dgvYemekListe.DataSource = yemekIslem.YemekListesiGetir();
        }

        private void tpIsListesi_Enter(object sender, EventArgs e)
        {
            Islem.WebAPI apiIslem = new WebAPI();
            isListesi = apiIslem.TotoListeGetir();
            userListe = apiIslem.UserListeGetir();
            dgvTotoListe.DataSource = isListesi.Select(s => new { s.id, s.title, s.completed }).ToList();
            cbUserListe.DataSource = userListe;
        }

        private void cbUserListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenUserId = Convert.ToInt32(cbUserListe.SelectedValue);
            var userIsListesi = isListesi.Where(p => p.userId == secilenUserId).ToList();
            dgvTotoListe.DataSource = userIsListesi;
        }

        private void btnGonderiEkle_Click(object sender, EventArgs e)
        {
            WebAPI api = new WebAPI();
            api.APIVeriGonder();

        }

        private void btnHavaDurumu_Click(object sender, EventArgs e)
        {
            WebAPI api = new WebAPI();
            api.HavaDurumuAPI();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            
            Islem.Models.Oturum.OturumuKapat();
            GirisForm girisForm = new GirisForm();
            this.Close();
            girisForm.ShowDialog();
            
        }
    }
}
