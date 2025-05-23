using Islem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta2
{
    public partial class MasaSaparisForm : Form
    {
        private bool ilkYukleme { get; set; } = true;
        private int MasaId { get; set; }
        Islem.SiparisIslem siparisIslem = new Islem.SiparisIslem();
        public MasaSaparisForm(int masaId)
        {

            MasaId = masaId;
            InitializeComponent();
        }

        public void MasaSaparisForm_Load(object sender, EventArgs e)
        {

            DataModel.LokantaModelContext model = new DataModel.LokantaModelContext();
            var secilenMasa = model.Masa.Include("Siparis").FirstOrDefault(m => m.Id == MasaId);
            if (secilenMasa != null)
            {
                lblMasaSiparisBaslik.Text = secilenMasa.Ad + " Sipariş Listesi";
            }
            //if (secilenMasa.Siparis != null)
            //{
            //    var siparisListe = secilenMasa.Siparis.Where(m => m.AktifMi == true).ToList();
            //    dgvMasaSiparisListe.DataSource = siparisListe;
            //}

            //var siparisListesi = siparisIslem.MasaSiparisGetir(MasaId);
            //dgvMasaSiparisListe.DataSource = siparisListesi;
            SiparisTazele();
            cbYemekListe.DataSource = siparisIslem.YemekListesiGetir();
            ilkYukleme = false;

        }

        private void cbYemekListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ilkYukleme == false)
            {
                var cb = sender as ComboBox;
                var secilenYemekId = Convert.ToInt32(cb.SelectedValue);
                DataModel.Siparis yeniSiparis = new DataModel.Siparis();
                yeniSiparis.MasaId = MasaId;
                yeniSiparis.YemekId = secilenYemekId;
                yeniSiparis.SiparihTarih = DateTime.Now;
                yeniSiparis.AktifMi = true;
                yeniSiparis.SiparisAlanKullaniciId = Oturum.KullaniciId;

                //Islem.SiparisIslem islem = new Islem.SiparisIslem();
                siparisIslem.SiparisEkle(yeniSiparis);

                SiparisTazele();
            }

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            siparisIslem.OdemeYap(MasaId);
            SiparisTazele();
            //dgvMasaSiparisListe.DataSource = siparisIslem.MasaSiparisGetir(MasaId);
        }

        private void SiparisTazele()
        {
            var siparisListesi = siparisIslem.MasaSiparisGetir(MasaId);
            dgvMasaSiparisListe.DataSource = siparisListesi;
            var toplamHesap = siparisListesi.Sum(p => p.Fiyat);
            lblHesap.Text = toplamHesap.ToString() + "TL";
        }

        private void MasaSaparisForm_FormClosed(object sender, FormClosedEventArgs e)
        {

          ///Form kapanırken yapılan işlemler burada yazılabilir.
            
        }
    }
}
