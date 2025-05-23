using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Identity.Client;

//using NewtonsoftJson

namespace Islem
{
    public class WebAPI:IIslem
    {
        public List<Models.Todo> TotoListeGetir()
        {
            ///Web API adresine talep göndererek servisten gelen verileri Toto
            ///listesi olarak döndürecek.
            List<Models.Todo>sonuc= new List<Models.Todo>();
            HttpClient istemci = new HttpClient();
            Uri servisAdresi = new Uri("https://jsonplaceholder.typicode.com");
            istemci.BaseAddress = servisAdresi;
            var cevap  = istemci.GetAsync("todos").Result;
            if (cevap != null && cevap.StatusCode==HttpStatusCode.OK)
            {
                ///verileri todo cinsinden listeye dönüştürme
                var jsonVeri=cevap.Content.ReadAsStringAsync().Result;
                sonuc = JsonSerializer.Deserialize<List<Models.Todo>>(jsonVeri);
            }
            return sonuc;
        }

        public List<Models.user> UserListeGetir()
        {
            ///Web API adresine talep göndererek servisten gelen verileri Toto
            ///listesi olarak döndürecek.
            List<Models.user> sonuc = new List<Models.user>();
            HttpClient istemci = new HttpClient();
            Uri servisAdresi = new Uri("https://jsonplaceholder.typicode.com");
            istemci.BaseAddress = servisAdresi;
            var cevap = istemci.GetAsync("users").Result;
            if (cevap != null && cevap.StatusCode == HttpStatusCode.OK)
            {
                ///verileri todo cinsinden listeye dönüştürme
                var jsonVeri = cevap.Content.ReadAsStringAsync().Result;
                sonuc = JsonSerializer.Deserialize<List<Models.user>>(jsonVeri);
            }
            return sonuc;
        }


        public List<Models.Gonderi> GonderiListeGetir()
        {
            ///Web API adresine talep göndererek servisten gelen verileri Toto
            ///listesi olarak döndürecek.
            List<Models.Gonderi> sonuc = new List<Models.Gonderi>();
            HttpClient istemci = new HttpClient();
            Uri servisAdresi = new Uri("https://jsonplaceholder.typicode.com");
            istemci.BaseAddress = servisAdresi;
            var cevap = istemci.GetAsync("posts").Result;
            if (cevap != null && cevap.StatusCode == HttpStatusCode.OK)
            {
                ///verileri todo cinsinden listeye dönüştürme
                var jsonVeri = cevap.Content.ReadAsStringAsync().Result;
                sonuc = JsonSerializer.Deserialize<List<Models.Gonderi>>(jsonVeri);
            }
            return sonuc;
        }


        ///Post işlemi yapan servis metodu kullanımı
        ///
        public bool APIVeriGonder()
        {
            HttpClient istemci = new HttpClient();
            istemci.BaseAddress= new Uri("https://jsonplaceholder.typicode.com");            
            Models.Gonderi yeniIs = new Models.Gonderi();
            yeniIs.userId = 4;
            yeniIs.title = "Sana yeni bir görev atıyorum";
            yeniIs.body = "Web servisi kullanmak keyiflidir. Öğreniniz. Sınavda çıkacak";
            
            string jsonVeri= JsonSerializer.Serialize(yeniIs);
            var content = new StringContent(jsonVeri);
            content.Headers.Add("Token", "ae5a4e5a4uie5a4u5ea5eui4a5uei");
            content.Headers.Add("Sehir", "Bilecik");

            var sonuc =  istemci.PostAsync("posts", content).Result;
            if (sonuc.StatusCode == HttpStatusCode.Created)
            {
                ///gerekli işlemler yapılır
                ///
                var liste = GonderiListeGetir();
                return true;
            }
            else
            {
               return false;
            }
        }


        public void HavaDurumuAPI()
        {
            //http://www.7timer.info/bin/api.pl?lon=113.17&lat=23.09&product=astro&output=json
            HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://api.open-meteo.com/v1/forecast");
            var sonuc = httpClient.GetAsync("http://www.7timer.info/bin/api.pl?lon=113.17&lat=23.09&product=astro&output=json").Result;
            var metin=sonuc.Content.ReadAsStringAsync().Result;
//            params = {
//                "latitude": 52.52,
//	"longitude": 13.41,
//	"hourly": "temperature_2m"
//}
        }
    }
}
