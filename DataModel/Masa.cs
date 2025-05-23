using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Masa:IEntity
    {
        public int Id { get; set; }
        public string? Kodu { get; set; }
        public string? Ad { get; set; }
        public int? Kapasite { get; set; }

        [Column("Eklenme_Tarihi")]
        public DateTime? EklenmeTarihi { get; set; }

        public ICollection<Siparis> Siparis { get; set; }
    }
}
