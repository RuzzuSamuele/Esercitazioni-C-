using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4_stampa_triangoli_rettangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi un numero:");
            int val = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= val; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}




/* int altezza = 0, val, i, j;
string valore;
Console.WriteLine("Scrivi un numero:");
valore = Console.ReadLine();
val = Convert.ToInt32(valore);
for (i = 1; i < val; i++)
{
    altezza = altezza + 1;
    for (j = 0; j < i; j++)
    {
        Console.WriteLine("*");
        Console.WriteLine("\n");
    }
}
Console.ReadKey(); 



Console.WriteLine("inserisci l'altezza del triangolo");
int altezza; */