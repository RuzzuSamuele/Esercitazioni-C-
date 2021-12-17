using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero e ti restituisco il suo cubo e il suo quadrato");
            string numero = Console.ReadLine();
            int num1, num2, num3, num, cubo, quadrato;
            double media;
            while (!(int.TryParse(numero, out num)))
            {
                Console.WriteLine("l'input inserito non è numerico: Riprova");
                numero = Console.ReadLine();
            }
                cubo = MyOperations.calcolaCubo(num);                                                       //Fa il cubo di un numero inserito
                Console.WriteLine("il cubo ottenuto è: " + cubo);
                quadrato = MyOperations.calcolaQuadrato(num);                                               //Fa il quadrato di un numero inserito
                Console.WriteLine("il quadrato ottenuto è: " + quadrato);
            
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Calcolo della media, inserisci il primo numero:");                           //Inserisci il primo numero
            numero = Console.ReadLine();
            while (!(int.TryParse(numero, out num1)))                                                       //Verifica se inserisco un numero correttamente
            {
                Console.WriteLine("l'input inserito non è numerico: Riprova");
                numero = Console.ReadLine();
            }    
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Inserisci il secondo numero:");                                                  //Inserisci il secondo numero
                numero = Console.ReadLine();
                while (!(int.TryParse(numero, out num2)))                                                           //Verifica se inserisco un numero correttamente
                {
                    Console.WriteLine("l'input inserito non è numerico: Riprova");
                    numero = Console.ReadLine();
                }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
                 media = MyOperations.media(num1, num2);                                                          //Calcola la media e mostra il risultato
                 Console.WriteLine("La media tra i due numeri è:" + media);
                    Console.WriteLine("Inserisci un terzo numero:");                                                //Inserisco il terzo numero
                    numero = Console.ReadLine();
                    while (!(int.TryParse(numero, out num3)))                                                       //Verifica se inserisco un numero correttamente
                    {
                        Console.WriteLine("l'input inserito non è numerico: Riprova");
                        numero = Console.ReadLine();
                    }           
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            media = MyOperations.media(num1, num2, num3);
            Console.WriteLine("La media tra i tre numeri è la seguente:" + media);                                  //Mostra la media dei tre numeri
            Console.ReadKey();
        }
    }
}
