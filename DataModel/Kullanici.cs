using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Kullanici:IEntity
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Parola { get; set; }
        public string? TcKimlikNo { get; set; }
        public bool? Cinsiyet { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }

        //public virtual ICollection<Siparis>? AlinanSiparisler { get; set; }
        //public virtual ICollection<Siparis>? AlinanHesaplar { get; set; }
    }
}
