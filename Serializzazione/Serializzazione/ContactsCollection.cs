using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializzazione
{
    public class ContactsCollection
    {
        public ICollection<Contact> Contacts { get; set; }

        public ContactsCollection()
        {
            // initialize array of objects in default constructor to generate sample data
            this.Contacts = new List<Contact>
                                            {
                                                 new Contact { Id = 7113, Name = "James Norris", BirthDate = new DateTime(1977, 5, 13), Phone = "488-555-1212",
                                                                Address = new Address { Street = "4627 Sunset Ave", City = "San Diego", State = "CA", PostalCode = "92115" } },
                                                 new Contact { Id = 7114, Name = "Mary Lamb", BirthDate =  new DateTime(1974, 10, 21), Phone = "337-555-1212",
                                                                  Address = new Address { Street = "1111 Industrial Way", City = "Dallas", State = "TX", PostalCode = "49245" } },
                                                    new Contact { Id = 7115, Name = "Robert Shoemaker", BirthDate = new DateTime(1968, 2, 8), Phone ="643-555-1212",
                                                                  Address = null }

                                                };
        }

    }
}