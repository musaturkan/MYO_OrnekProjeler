namespace Lokanta
{
    public partial class LokantaBaslat : Form
    {
        public string KurumAdi { get; set; }
        public LokantaBaslat()
        {
            InitializeComponent();
        }

        public LokantaBaslat(string _kurumAdi)
        {
            KurumAdi = _kurumAdi;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Merhaba.Text = "Ramazanda dersler baþka güzel";
            lbl_Merhaba.Size = new System.Drawing.Size(5, 25);
            Font yeniFont = new Font("Candara", 24);
            lbl_Merhaba.Font = yeniFont;
            lbl_Merhaba.ForeColor = System.Drawing.Color.Brown;
            tb_KullaniciAd.BackColor = System.Drawing.Color.White;
            tb_Parola.BackColor = System.Drawing.Color.White;
        }

        private void btn_Merhaba_Click(object sender, EventArgs e)
        {
            //butona týklanýnca labala mesaj yazýlacak
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            //Yeni bir form açma kodu buraya yazýlacak
            List<DataModel.Masa> masalar = new List<DataModel.Masa>();
            //masalar.Add(new DataModel.Masa { Ad = "Masa1", Id = 1, Kapasite = 4 });
            //masalar.Add(new DataModel.Masa { Ad = "Masa2", Id = 2, Kapasite = 4 });
            //masalar.Add(new DataModel.Masa { Ad = "Masa3", Id = 3, Kapasite = 2 });
            //masalar.Add(new DataModel.Masa { Ad = "Masa4", Id = 4, Kapasite = 8 });
            //masalar.Add(new DataModel.Masa { Ad = "Masa5", Id = 1, Kapasite = 6 });
            
            DataModel.LokantaModelContext model = new DataModel.LokantaModelContext();
            masalar = model.Masa.ToList();
            var kullaniciListe = model.Kullanici.ToList();
            var yemekTurListe = model.YemekTur.ToList();

            ///Prporety ile veri taþýma
            Yonetim yonetim = new Yonetim();
            yonetim.MasaListe = masalar;            
            yonetim.ShowDialog();
            //this.Close();
            //yonetim.Show();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
