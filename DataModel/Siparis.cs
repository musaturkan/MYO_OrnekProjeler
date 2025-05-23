using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    //[Table("Siparis")]
    public class Siparis:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int MasaId { get; set; }
        public int YemekId { get; set; }

        [Column("Tarih")]
        public DateTime SiparihTarih { get; set; }

        [ForeignKey("YemekId")]
        public virtual Yemek? Yemek { get; set; }

        [ForeignKey("MasaId")]
        public virtual Masa? Masa { get; set; }
        public bool? AktifMi { get; set; }

        public int? SiparisAlanKullaniciId { get; set; }

        [ForeignKey("SiparisAlanKullaniciId")]
        public virtual Kullanici? SiparisAlanKullanici { get; set; }

        public int? HesapAlanKullaniciId { get; set; }

        [ForeignKey("HesapAlanKullaniciId")]
        public virtual Kullanici? HesapAlanKullanici { get; set; }
    }
}
