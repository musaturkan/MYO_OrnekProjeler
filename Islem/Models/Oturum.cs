using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Islem.Models
{
    /// <summary>
    /// Oturum açan kullanıcı bilgilerin saklamak için kullanılan sınıftır
    /// </summary>
    public static class Oturum
    {
        public static string? Ad{get;private set;}
        public static string? Soyad { get;private set; }
        public static bool? AcikMi { get;private set; }
        public static int? KullaniciId { get; private set; }
        public static string? Cinsiyet { get; set; }
        public static string? KayitTarihi { get; set; }
        public static void OturumBaslat(DataModel.Kullanici kullanici)
        {
            Ad = kullanici.Ad;
            Soyad = kullanici.Soyad;
            KullaniciId = kullanici.Id;
            AcikMi = true;
            KayitTarihi = kullanici.KayitTarihi?.ToString();
            if (kullanici.Cinsiyet==false)
            {
                Cinsiyet = "Erkek";
            }
            else
            {
                Cinsiyet = "Kadın";
            }
        }

        public static void OturumuKapat()
        {
            Oturum.AcikMi = false;
            Oturum.KullaniciId = null;
            Oturum.Ad = null;
            Oturum.Soyad = null;
        }
    }
}
