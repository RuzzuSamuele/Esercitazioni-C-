using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_pratica__arrayList_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int valore_nome;
            int valore_eta;
            int valore_peso;
            int valore_altezza;
            Console.WriteLine("Inserisci nome di una persona:");
            string name = Console.ReadLine();
            while ((int.TryParse(name, out valore_nome)))
            {
                Console.WriteLine("Errato, devi inserire il nome della persona:");
                name = Console.ReadLine();
            }
            Console.WriteLine("Inserisci età di una persona:");
            string eta = Console.ReadLine();
            while (!(int.TryParse(eta, out valore_eta)))
            {
                Console.WriteLine("Errato, devi inserire l'età della persona:");
                eta = Console.ReadLine();
            }
            Console.WriteLine("Inserisci il peso della persona");
            string peso = Console.ReadLine();
            while(!(int.TryParse(peso, out valore_peso)))
            {
                Console.WriteLine("Errato, devi inserire il peso della persona:");
                peso = Console.ReadLine();
            }
            Console.WriteLine("Inserisci l'altezza della persona");
            string altezza = Console.ReadLine();
            while (!(int.TryParse(altezza, out valore_altezza)))
            {
                Console.WriteLine("Errato, devi inserire l'altezza della persona:");
                altezza = Console.ReadLine();
            }
            Person p = new Person(name, valore_eta, valore_peso, valore_altezza);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
