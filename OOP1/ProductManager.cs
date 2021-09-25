using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //ürünle ilgili yapılacak olan operasyonların sınıfı.
    class ProductManager
    {
        public void Add (Product product)
        {
            Console.WriteLine(product.ProductName + " ÜRÜN EKLENDİ.");   
        }
        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " ÜRÜN GÜNCELLENDİ.");
        }

    }
}
