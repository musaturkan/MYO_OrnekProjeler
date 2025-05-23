using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public static class Fabrika
    {
        public static T IslemNesnesiGetir<T>() where T:class,IIslem, new()
        {
            return new T();
        }

        public static T DtoNesnesiGetir<T>()where T:class,IDto, new()
        {
            return new T();
        }

        public static T EntityGetir<T>()where T:class,DataModel.IEntity,new()
        {
            return new T();
        }

        public static ILog LogNesnesiGetir()
        {
            return new VeriTabaniLog();
        }
        //public static YemekIslem YemekIslemGetir()
        //{
        //    return new YemekIslem();
        //}

        //public static SiparisIslem SiparisIslemGetir()
        //{
        //    return new SiparisIslem();
        //}
    }
}
