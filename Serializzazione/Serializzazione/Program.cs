using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializzazione
{



    public class Program
    {
        static void Main(string[] args)
        {

            ContactsCollection ct = new ContactsCollection();
            string risultato = Newtonsoft.Json.JsonConvert.SerializeObject(ct);
            foreach (char c in risultato)
            {
                Console.Write(c);
                if (c == ',')
                {
                    Console.WriteLine();
                }



            }
            Console.ReadKey();


            string fileName = "WeatherForecast.json";
            string jsonString = File.ReadAllText(fileName);
            Program ContactsCollection = JsonSerializer.Deserialize<ContactsCollection>(jsonString);
        }



    }



}
