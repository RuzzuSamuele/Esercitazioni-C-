using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_3_Tutte_le_operazioni_8_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string N1, N2, simbolo;
            int n1, n2, resto;
            float operazione;
            Console.WriteLine("\t\t\t\t\tCalcolatrice che fa tutte le operazioni");
            Console.WriteLine("\b\b GUIDA ALL'USO DEL PROGRAMMA:");
            Console.WriteLine(" Inserisci '+' tra un numero e l'altro per svolgere l'operazione: SOMMA");
            Console.WriteLine(" Inserisci '-' tra un numero e l'altro per svolgere l'operazione: SOTTRAZIONE");
            Console.WriteLine(" Inserisci '/' tra un numero e l'altro per svolgere l'operazione: DIVISIONE");
            Console.WriteLine(" Inserisci '*' tra un numero e l'altro per svolgere l'operazione: MOLTIPLICAZIONE");
            Console.WriteLine("\n\n\t\t\t\t\t\tInserisci il primo numero");
                N1 = Console.ReadLine();
                while(!(int.TryParse(N1, out n1)))
                {
                    Console.WriteLine("Attento, scrivi un numero.");
                    N1 = Console.ReadLine();
                }
            Console.WriteLine("Scegli un'operazione scrivendo esattamente uno dei simboli elencati nella guida:");
            simbolo = Console.ReadLine();
            switch (simbolo)
            {
                case "+":
                    Console.WriteLine("Hai scelto l'operazione SOMMA, inserisci il secondo numero:");
                    N2 = Console.ReadLine();
                    while (!(int.TryParse(N2, out n2)))
                    {
                        Console.WriteLine("Attento, scrivi un numero.");
                        N2 = Console.ReadLine();
                    }
                    operazione = n1 + n2;
                    Console.WriteLine("Il risultato è:" + operazione);
                    break;
                case "-":
                    Console.WriteLine("\nHai scelto l'operazione SOTTRAZIONE, inserisci il secondo numero:");
                    N2 = Console.ReadLine();
                    while (!(int.TryParse(N2, out n2)))
                    {
                        Console.WriteLine("Attento, scrivi un numero.");
                        N2 = Console.ReadLine();
                    }
                    operazione = n1 - n2;
                    Console.WriteLine("Il risultato è:" + operazione);
                    break;
                case "/":
                    Console.WriteLine("\nHai scelto l'operazione DIVISIONE, inserisci il secondo numero:");
                    N2 = Console.ReadLine();
                    while (!(int.TryParse(N2, out n2)))
                    {
                        Console.WriteLine("Attento, scrivi un numero.");
                        N2 = Console.ReadLine();
                    }
                    operazione = n1 / n2;
                    resto = n1 % n2; 
                    Console.WriteLine("Il risultato è:" + operazione);
                    Console.WriteLine($"Il resto della divisione con risultato {operazione} è:" + resto);
                    break;
                case "*":
                    Console.WriteLine("Hai scelto l'operazione MOLTIPLICAZIONE, inserisci il secondo numero:");
                    N2 = Console.ReadLine();
                    while (!(int.TryParse(N2, out n2)))
                    {
                        Console.WriteLine("Attento, scrivi un numero.");
                        N2 = Console.ReadLine();
                    }
                    operazione = n1 * n2;
                    Console.WriteLine("Il risultato è:" + operazione);
                    break;
                default:
                    Console.WriteLine("\a Operazione non identificata");
                    break;
            }
            Console.ReadKey();
        }
    }
}
