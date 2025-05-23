using Nesneler;

//Temel programalama yapıları:
//karar yapıları
//döngüler
//değişkenler
//iç içe döngüler
int sayi=40;

Arac yeniArac = new Arac(60,"Kırmızı","Togg","Elektrikli");

//yeniArac.UretimYili = 2025;
//yeniArac.Marka = "TOGG";
//yeniArac.Renk = "Yeşil";
//yeniArac.YakitTuru = "Elektrik";
Console.WriteLine(yeniArac.Renk);

//yeniArac. = -95;
///property:sınıfın üylerinin kontrollü şekilde nesne üzerinden erişime açılmasıdır
///
Console.WriteLine(sayi);
Console.WriteLine("Merhaba");
yeniArac.BilgiYaz();
yeniArac.YakitYukle(50);

yeniArac.HareketEt(347);

yeniArac.HareketEt(245);
   // yeniArac.BilgiYaz();
Surucu sofor1=new Surucu();
sofor1.Ad = "Muhsin";
sofor1.Soyad = "Karakaya";
sofor1.Id = 110;
sofor1.DogumTarihi = DateTime.Now.AddYears(-30);
yeniArac.AracSurucu=sofor1;
Console.WriteLine(yeniArac.AracSurucu.Ad);