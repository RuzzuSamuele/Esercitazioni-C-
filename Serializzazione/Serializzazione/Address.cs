using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializzazione
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode = "99999"; // initialize properties to generate sample data

        public Address()
        {
            // or set properties in default constructor to generate sample data
            this.Street = "4627 Sunset Ave"; this.City = "San Diego"; this.State = "CA"; this.PostalCode = "92115";
        }
    }
}
