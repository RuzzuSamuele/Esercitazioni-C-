using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializzazione
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public Contact()
        {
            this.Id = 7113; this.Name = "James Norris"; this.BirthDate = new DateTime(1977, 5, 13); this.Phone = "488-555-1212";
            this.Address = new Address();
        }
    }
}