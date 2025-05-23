using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public class Log:ILog
    {
        //public void TextLogEkle(string log)
        //{
        //    ///Burada gönderilen log değeri bir txt dosyasına eklenecek
        //}

        //public void VeritabaniLogEkle(string log)
        //{
        //    ///burada gönderilen log değeri veri tabanı tablosuna ekelnece
        //}

        //public void ServisLogEkle(string log)
        //{
        //    ///burada gönderilen log değeri bir web serevise gönderilecek
        //}

        public void LogYaz(string message)
        {
            //Log veri tabanına yazılacak
        }
    }

    public class VeriTabaniLog : ILog
    {
        public void LogYaz(string message)
        {
            ///veritabanı log işlemelir olaca
        }
    }

    public class ServisLog : ILog
    {
        public void LogYaz(string message)
        {
            ///log servise gönderilece
        }
    }

    public class TextLog : ILog
    {
        public void LogYaz(string message)
        {
            ///text dosyasına log yazılcak
        }
    }
}
