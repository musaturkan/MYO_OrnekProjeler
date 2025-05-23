using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public class YemekIslem:IIslem
    {
        public void YemekEkle(DataModel.Yemek yeniYemek)
        {
            DataModel.LokantaModelContext model=new DataModel.LokantaModelContext();
            model.Yemek.Add(yeniYemek);
            model.SaveChanges();
        }

        public List<DataModel.Yemek> YemekListesiGetir()
        {
            DataModel.LokantaModelContext model = new DataModel.LokantaModelContext();
            return model.Yemek.ToList();
        }
    }
}
