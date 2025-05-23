using Islem;
using Islem.Models;
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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            OturumIslem oturumIslem = new OturumIslem();
            var sonuc = oturumIslem.OturumBaslat(tbKullaniciAdi.Text, tbParola.Text);
            if (Oturum.AcikMi == true)
            { 
                this.Hide();
                AnaForm form = new AnaForm();
                form.ShowDialog();
                
            }
            else 
            {
                MessageBox.Show("Kullanıcı doğrulanamadı");                
            }
        }
    }
}
