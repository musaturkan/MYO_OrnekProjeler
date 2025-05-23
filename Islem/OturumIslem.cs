using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Islem.Models;
using Microsoft.EntityFrameworkCore;

namespace Islem
{
    public class OturumIslem:IIslem
    {
        DataModel.LokantaModelContext model = new DataModel.LokantaModelContext();
        public bool OturumBaslat(string KullaniciAdi,string Parola)
        {
            ///Veri tabanından kullanıcıyı doğrulayacak
            var kullanici = model.Kullanici.FirstOrDefault(p=>p.KullaniciAdi==KullaniciAdi
            && p.Parola == Parola);

            if (kullanici != null) 
            {
                //Oturum.Ad = kullanici.Ad;
                //Oturum.Soyad = kullanici.Soyad;
                //Oturum.AcikMi = true;
                //Oturum.KullaniciId = kullanici.Id;
                Oturum.OturumBaslat(kullanici);
                return true;
            }
            else
            {
                return false;     
            }
        }

        public void OturumKapat()
        {
            ///Başlatılmış oturumu kapatacak
        }
    }
}
