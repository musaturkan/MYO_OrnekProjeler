using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneler
{
    /// <summary>
    /// Araç nesneleri için temel özellikleri barındıran sınıftır
    /// </summary>
    public class Arac
    {
        public Arac(int _depoKapasite,string _renk,string _marka,string _yakitTuru) 
        {
            marka = _marka.ToUpper();
            depoKapasite = _depoKapasite;
            renk = _renk.ToUpper();
            yakitTuru = _yakitTuru.ToUpper();
        }
        private string marka;
        private int uretimYili;
        private string renk;
        private float yakitMiktari;
        private string yakitTuru;        
        private int depoKapasite;

        /// <summary>
        /// Araç sürücü bilgileri bir sürücü nesnesi ile Araç sınıfında kullanılır
        /// </summary>
        public Surucu AracSurucu { get; set; }
        ///property:sınıfın üylerinin kontrollü şekilde nesne üzerinden erişime açılmasıdır <summary>
        /// property:sınıfın üylerinin kontrollü şekilde nesne üzerinden erişime açılmasıdır

        public int DepoKapasitesi { get { return depoKapasite; } }
        public string Marka { get { return marka; } }
        public int UretimYili { get { return uretimYili;} }
        public float YakitMiktari { get { return yakitMiktari; } }
        public string YakitTuru { get { return yakitTuru; } }
        public string Renk 
        {
            get
            {
                return renk;
            }
            //set 
            //{
            //    renk = value.ToUpper();
            //}
        }

        public float MaksimumKm { get { return yakitMiktari * 10; } }
        ///sınıf içinde iş yapan, görev icra eden elemanlara metot denir
        ///Metotlar parametreli veya parametresiz tanımalnabilir
        ///Metodun geri dönüş tipi belirtilmek zorundadır
        ///Geri bir şey döndürmüyorsa void anahtar kelimesi ile bildirilmesi zorunludur
        public void BilgiYaz()
        {
            Console.WriteLine(YakitMiktari);
            Console.WriteLine(YakitTuru);
            Console.WriteLine(UretimYili);
            Console.WriteLine(Renk);
            Console.WriteLine(Marka);
            Console.WriteLine("Kalan maksimum km:{0}",MaksimumKm);
            Console.WriteLine("Şoför bilgileri:{0} {1}",AracSurucu.Ad,AracSurucu.Soyad);
        }

        public void YakitYukle(int yuklenenYakit)
        {
            if (yuklenenYakit > 0)
            {

                float yeniMiktar = yakitMiktari + yuklenenYakit;

                if (yeniMiktar > depoKapasite)
                {
                    yakitMiktari = depoKapasite;
                }
                else
                {
                    yakitMiktari = yeniMiktar;
                }
            }
            else 
            {
                Console.WriteLine("Eksi miktar yüklenemez");
            }
            
        }

        public void HareketEt(int km)
        {
            YakitAzalt(km);

            Console.WriteLine("Kalan maksumum km{0}", MaksimumKm);
            Console.WriteLine("Kalan yakit miktarı:{0}", yakitMiktari);
        }


        private void YakitAzalt(int km)
        {
            if (km <= MaksimumKm)
            {
                yakitMiktari -= km / 10;
                if (yakitMiktari < 0)
                {
                    yakitMiktari = 0;
                }
                Console.WriteLine("Araç {0} .km hareket etti", km);               
            }
            else
            {
                yakitMiktari = 0;
                Console.WriteLine("Yeterli yakıt yok. Bu yüzden {0}km hareket edilebildi", MaksimumKm);             
            }
        }

    }
    
}
