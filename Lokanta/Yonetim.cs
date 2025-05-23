using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta
{
    public partial class Yonetim : Form
    {
        public List<DataModel.Masa> MasaListe = new List<DataModel.Masa>();

        public Yonetim()
        {
            InitializeComponent();
        }

        private void Yonetim_Load(object sender, EventArgs e)
        {
            dgv_MasaListe.DataSource = MasaListe;

            ///Form üzerine dinamik olarak yani porogramatik olarak buton eklenmesi
            Button btn = new Button();
            btn.Text = "Ben Dinamik Butonum";
            btn.Size = new System.Drawing.Size(100, 50);
            btn.Location = new System.Drawing.Point(100, 10);
            btn.Click += new EventHandler(masa_Btn_Click);
            this.Controls.Add(btn);
        }
        /// <summary>
        /// Bir metot olaya bağlanacaksa object türünden bir parametresi ve EventArgs türünden ikinci parametresi olmalıdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void masa_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
