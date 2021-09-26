using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //GerçekMüşteri
    class RealCustomer:Customer
    {

        public string IdentificationNumber { get; set; } //tc no

        public string FirstName { get; set; } // adı

        public string LastName { get; set; } //soyadı

    }
}
