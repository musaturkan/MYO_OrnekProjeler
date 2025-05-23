using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class YemekTur:IEntity
    {
        public int Id { get; set; }
        public string?  Ad { get; set; }
        public string? KisaAd { get; set; }
        public ICollection<Yemek>? Yemek { get; set; }
    }
}
