using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    /// <summary>
    /// DTO nesnesi
    /// </summary>
    public class MasaYemekSiparis:IDto
    {
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string YemekAdi { get; set; }
        public decimal? Fiyat { get; set; }
    }
}
