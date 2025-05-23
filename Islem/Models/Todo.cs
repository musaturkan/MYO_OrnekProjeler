using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem.Models
{
    /// <summary>
    /// Web API'dan gelen verileri temsil eden sınıftır.
    /// todo servis metodunun döndürdüğü nesneleri temsil eder
    /// </summary>
    public class Todo
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
