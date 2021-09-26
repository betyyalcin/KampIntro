using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    //: bu olaydan sonra yazılan olaya miras(inheritance) diyoruz. 
    class LegalCustomer:Customer
    {
      
        public string CompanyName { get; set; } // şirket adı

        public string TaxNumber { get; set; } //Vergino
    }
}
