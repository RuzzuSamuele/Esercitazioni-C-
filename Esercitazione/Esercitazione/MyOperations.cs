using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class MyOperations
    {
        public static int calcolaCubo(int num)
        {
            return (num * num * num);
        }
        public static int calcolaQuadrato(int num)
        {
            return (num * num * num * num);
        }
        public static double media(int num1, int num2)
        {
            return ((double) num1 + num2) / 2;
        }
        public static double media(int num1, int num2, int num3)
        {
            return ((double) num1 + num2 + num3) / 3;
        }
    }
}
