using System;
using System.Collections.Generic;
using System.Text;

namespace OyunUygulaması
{
    class KampanyaManager
    {
        public KampanyaManager(YeniKampanyaUygulanmasi yeniKampanyaUygulanmasi)
        {
            YeniKampanyaUygulanmasi = yeniKampanyaUygulanmasi;
        }

        public YeniKampanyaUygulanmasi YeniKampanyaUygulanmasi { get; }

        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi: " +  kampanya.Ad  + " Fiyatı : " +   kampanya.Fiyat + " İndirimli Fiyatı: " +   kampanya.IndirimliFiyat);
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Güncellendi : " +  kampanya.Ad  + " Fiyatı : " +   kampanya.Fiyat + " İndirimli Fiyatı: " +  kampanya.IndirimliFiyat);
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Silindi: " + kampanya.Ad +  " Fiyatı : " + kampanya.Fiyat + " İndirimli Fiyatı: " +  kampanya.IndirimliFiyat);
        }
    }
}
