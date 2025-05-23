using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Islem.Models;
using Microsoft.EntityFrameworkCore;

namespace Islem
{
    /// <summary>
    /// Masalara sipariş alındığnıda bu işlem burdake metotlarla yapılacak.
    /// Masaların dolululk durumaları buradan görülebilecek.
    /// </summary>
    public class SiparisIslem :IIslem
    {
        /// <summary>
        /// Masa tablosundaki tüm kayıtları Masa nesne listesi olarak döndürür.
        /// </summary>
        /// <returns>Masa entitysi cinsinden elemanların olduğu bir listedir</returns>
        public List<Masa> MasaListesiGetir()
        {
            DataModel.LokantaModelContext model=new DataModel.LokantaModelContext();
            var liste = model.Masa.Include(m=>m.Siparis.Where(s=>s.AktifMi==true)).ToList();
            return liste;
            
        }

        public List<Yemek> YemekListesiGetir()
        {
            DataModel.LokantaModelContext model = new DataModel.LokantaModelContext(); 
            var yemekListesi=model.Yemek.ToList();
            return yemekListesi;
        }

        public void SiparisEkle(Siparis yeniSiparis)
        {
            DataModel.LokantaModelContext model = new LokantaModelContext();
            yeniSiparis.AktifMi = true;
            model.Siparis.Add(yeniSiparis);
            model.SaveChanges();
        }


        public void SiparisSil(int SiparisId)
        {
            DataModel.LokantaModelContext model = new LokantaModelContext();
            var silinecekSiparis = model.Siparis.FirstOrDefault(s=>s.Id==SiparisId);
            if (silinecekSiparis != null)
            {
                model.Siparis.Remove(silinecekSiparis);
                model.SaveChanges();
            }
           
        }

        public List<MasaYemekSiparis> MasaSiparisGetir(int MasaId) 
        {
            DataModel.LokantaModelContext model = new DataModel.LokantaModelContext();
            var liste = model.Siparis.Include("Yemek").Where(p=>p.MasaId== MasaId && p.AktifMi==true)
                .Select(s=>new MasaYemekSiparis {
                SiparisId = s.Id,
                SiparisTarihi = s.SiparihTarih,
                YemekAdi = s.Yemek.Ad,
                Fiyat = s.Yemek.Fiyat
                }).ToList();
            return liste;
        }

        /// <summary>
        /// MasaId ile belirtilen masanın siparişlerini ödendi olarak işaretler
        /// </summary>
        /// <param name="MasaId"></param>
        public void OdemeYap(int MasaId)
        {
            DataModel.LokantaModelContext model = new LokantaModelContext();
            var masaAktifSiparisListe=model.Siparis.Where(s=>s.MasaId==MasaId && s.AktifMi==true).ToList();
            foreach (var siparis in masaAktifSiparisListe)
            {
                siparis.HesapAlanKullaniciId = Oturum.KullaniciId;
                siparis.AktifMi = false;                
            }
            model.SaveChanges();
        }
    }
}
