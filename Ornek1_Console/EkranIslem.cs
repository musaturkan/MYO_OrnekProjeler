using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_Console
{

    public class EkranIslem
    {
        int yas;
        int yil;
        static string Ad = "Leyla";
        public static void EkranaYaz(string veri)
        {
            //Ad = "Emirhan";
            //int yazmaSayisi = 20;
            Console.WriteLine(Ad);
            Console.WriteLine(veri);
        }

        public static void Hesapla(int veri)
        {
            Ad = "Mehmet";

        }
    }

    public class OrnekSinif
    {
        public void EkranaYaz(string veri)
        {

        }
    }
}