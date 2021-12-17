using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_2__05_11_21_
{
    class Program
    {
        static void Main(string[] args)
        {
            string lato_1;
            string lato_2;
            string lato_3;
            int l_1;
            int l_2;
            int l_3;
            Console.WriteLine("\t\t\t\t\tProgramma che riconosce i triangoli");
            Console.WriteLine("\n\nInserisci il valore del primo lato:");
            lato_1 = Console.ReadLine();
            while (!(int.TryParse(lato_1, out l_1)))
            {
                Console.WriteLine("Non è un numero");
                lato_1 = Console.ReadLine();
            }
            //-------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nInserisci il valore del secondo lato:");
            lato_2 = Console.ReadLine();
            while (!(int.TryParse(lato_2, out l_2)))
            {
                Console.WriteLine("Non è un numero");
                lato_2 = Console.ReadLine();
            }
            //--------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nInserisci il valore del terzo lato:");
            lato_3 = Console.ReadLine();
            while (!(int.TryParse(lato_3, out l_3)))
            {
                Console.WriteLine("Non è un numero");
                lato_3 = Console.ReadLine();
            }
            //--------------------------------------------------------------------------------------------------------
            l_1 = Convert.ToInt32(lato_1);
            l_2 = Convert.ToInt32(lato_2);
            l_3 = Convert.ToInt32(lato_3);
            //--------------------------------------------------------------------------------------------------------
            if ((l_1 + l_2 < l_3) || (l_1 + l_3 < l_2) || (l_2 + l_3 < l_1))
            {
                Console.WriteLine("\t\t\t\t\t\tQuesto triangolo non può esistere !");
            }else
            {
                    if ((l_1 == l_2) && (l_2 == l_3) && (l_1 == l_3))
                    {
                        Console.WriteLine("\t\t\t\t\t\tIl triangolo è equilatero");
                    }
                //--------------------------------------------------------------------------------------------------------
                        else if ((l_1 == l_2) || (l_1 == l_3) || (l_2 == l_3) && (l_1 != l_2) || (l_1 != l_3) || (l_2 != l_3))
                        {
                            Console.WriteLine("\t\t\t\t\t\til triangolo è isoscele");
                        }
                //---------------------------------------------------------------------------------------------------------
                            else if ((l_1 != l_2) && (l_1 != l_3) && (l_2 != l_3))
                            {
                                Console.WriteLine("\t\t\t\t\t\tIl triangolo è scaleno");
                            }

            }    //---------------------------------------------------------------------------------------------------------
            Console.ReadKey();
            
        }
    }
}
