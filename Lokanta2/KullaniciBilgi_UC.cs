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
    public partial class KullaniciBilgi_UC : UserControl
    {
        public string? Ad
        {
            get => lblAd.Text;
            set => lblAd.Text = value;
        }

        public string? Soyad
        {
            get => lblSoyad.Text;
            set => lblSoyad.Text = value;
        }

        public string? KayitTarihi
        {
            get => lblKayitTarihi.Text;
            set => lblKayitTarihi.Text = value;
        }

        public string? Cinsiyet
        {
            get => lblCinsiyet.Text;
            set => lblCinsiyet.Text = value;
        }
        public KullaniciBilgi_UC()
        {
            InitializeComponent();

        }

        private void KullaniciBilgi_UC_Load(object sender, EventArgs e)
        {
            if (Islem.Models.Oturum.AcikMi == true)
            {
                Ad = Islem.Models.Oturum.Ad;
                Soyad = Islem.Models.Oturum.Soyad;
                KayitTarihi = Islem.Models.Oturum.KayitTarihi;
                Cinsiyet = Islem.Models.Oturum.Cinsiyet;

                if (Cinsiyet == "Kadın")
                {
                    BackColor = Color.Pink;
                }
                else
                {
                    BackColor = Color.Blue;
                }

                
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Islem.Models.Oturum.OturumuKapat();
        }
    }
}
