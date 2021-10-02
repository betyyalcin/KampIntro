using System;
using System.Collections.Generic;
using System.Text;

namespace OyunUygulaması
{
    class UyeManager
    {
        UyeDogrulamasi _uyeDogrulamasi;

        public UyeManager(UyeDogrulamasi uyeDogrulamasi)
        {
            _uyeDogrulamasi = uyeDogrulamasi;
        }

        public void Add (Uye uye)
        {
           Console.WriteLine("Kullanıcı Eklendi: " + uye.Ad + uye.Soyad);
        }

        public void Update (Uye uye)
        {
            Console.WriteLine("Kullanıcı Güncellendi: " + uye.Ad + uye.Soyad);
        }

        public void Delete ( Uye uye)
        {
            Console.WriteLine("Kullanıcı Silindi: " + uye.Ad + uye.Soyad);
        }
    }
}
