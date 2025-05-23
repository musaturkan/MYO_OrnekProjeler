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
    public partial class YemekBilgi_UC : UserControl
    {
        public string Ad { 
            get => lblAd.Text; 
            set => lblAd.Text = value; }

        public string Fiyat { 
            get => lblFiyat.Text; 
            set => lblFiyat.Text = value; }

        public string Mesaj { get; set; }
        public YemekBilgi_UC()
        {
            InitializeComponent();
        }

        private void YemekBilgi_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
