using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        //syntax
        public void Ekle (Urun urun)
        {
            Console.WriteLine(urun.Adi + " Sepete Eklendi!");

        }

        public void Ekle2 (string urunAdi, string aciklama, double Fiyat, int stokAdeti )
        {
            Console.WriteLine(urunAdi + " Sepete Eklendi!");

        }
    }
}
