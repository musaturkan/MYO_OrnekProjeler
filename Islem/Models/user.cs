﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem.Models
{
    public class user
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public adress address { get; set; }      
        public string phone { get; set; }
        public string website { get; set; }
        public sirket company { get; set; }
    }
}
