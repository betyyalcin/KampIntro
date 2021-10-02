using System;
using System.Collections.Generic;
using System.Text;

namespace OyunUygulaması
{
    class UyeDogrulamaManager : UyeDogrulamasi
    {
        public bool Validate(Uye uye)
        {
            if (uye.DogumYili == "23.04.1999" && uye.Ad =="Betül" && uye.Soyad == "Yalçın" && uye.TcNo== 123344566)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
