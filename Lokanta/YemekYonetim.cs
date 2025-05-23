using DataModel;
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
    public partial class YemekYonetim : Form
    {
        public YemekYonetim()
        {
            InitializeComponent();

        }

        private void YemekYonetim_Load(object sender, EventArgs e)
        {
            ///EntityFramework ile veri tabanından kayıtları listelemek
            LokantaModelContext model = new LokantaModelContext();

            ///Yemek tablosundaki tüm kayıtların listelenmesi
            ///select * from Yemek
            ///
            //var liste = model.Yemek.ToList();
            ///Veri tabanındaki tablodan yalnızca istenen sütunları ef sorgusu ile listemek
            var liste1 = model.Yemek.Select(y => new
                                    {
                                        y.Id,
                                        y.Ad,
                                        y.Fiyat,
                                        y.Kalori,
                                        YemekTuru = y.YemekTur.Ad
                                    }).ToList();
            ///Veri tabanındaki tabloyu Linq ile sorgulamak
            var liste = (from y in model.Yemek
                        select new
                        {
                            y.Id,
                            Ad = y.Ad,
                            SatisFiyatı = y.Fiyat,
                            Kalori = y.Kalori,
                            YemekTuru = y.YemekTur.Ad
                        }).ToList();
            ///select yemek.ad,yemek.Fiyat,yemek.Kalori, yemekTur.Ad YemekTuru
            ///from Yemek
            ///inner join YemekTur on Yemek.YemekTurId=YemekTur.Id

            //List<Masa> liste2 = model.Masa.ToList();
            ///yemek listesinin form kontrolüne bağlanması
            dgv_YemekListe.DataSource = liste1;
        }

       
    }
}
