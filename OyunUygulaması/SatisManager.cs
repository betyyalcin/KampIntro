using System;
using System.Collections.Generic;
using System.Text;

namespace OyunUygulaması
{
    class SatisManager:Kampanya
    {
        private Satis satisUygulamasi;

        public SatisManager(Satis satisUygulamasi)
        {
            this.satisUygulamasi = satisUygulamasi;
        }

        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Satışlarda Kampanya Uygulandı Yapıldı :" );
        }
    }
}
