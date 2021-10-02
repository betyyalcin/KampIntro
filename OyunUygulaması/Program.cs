using System;

namespace OyunUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            UyeManager uyeManager = new UyeManager(new YeniUyeDogrulama());
            uyeManager.Add(new Uye
            {
                Id = 1,
                Ad = "Betül",
                Soyad = "Yalçın",
                TcNo = 123344566,
                DogumYili = "23.04.1999"
            });
            KampanyaManager kampanyaManager = new KampanyaManager(new YeniKampanyaUygulanmasi());
            kampanyaManager.Add(new Kampanya
            {
                Id = 1,
                Ad = "Mobil Legends",
                Fiyat = 150,
                IndirimliFiyat = 120
            });

           
        }
    }
}
