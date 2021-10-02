using System;
using System.Collections.Generic;
using System.Text;

namespace OyunUygulaması
{
    class YeniKampanyaUygulanmasi : KampanyaUgulanmasi
    {
        public bool Validate(Kampanya kampanya)
        {
            return true;
        }

        public bool Validate(Uye uye)
        {
            throw new NotImplementedException();
        }
    }
}
