using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizio_Thread
{
    class Program
    {
        static void Main()
        {
            Thread a = new Thread(Go_a), b = new Thread(Go_b), c = new Thread(Go_c);
            Thread d = new Thread(Go_d), e = new Thread(Go_e);
            Random random = new Random();
            int attesa = random.Next(5000);
            a.Start();
            a.Join();
            Console.WriteLine("\nil thread 'a' ha finito");
            b.Start();
            b.Join();
            Console.WriteLine("\nil thread 'b' ha finito");
            c.Start();
            c.Join();
            Console.WriteLine("\nil thread 'c' ha finito");
            d.Start();
            d.Join();
            Console.WriteLine("\nil thread 'd' ha finito");
            e.Start();
            e.Join();
            Console.WriteLine("\nil thread 'e' ha finito");
            void Go_a()
            {
                 Console.Write("a");
            }
            void Go_b()
            {
                 Console.Write("b");
            }
            void Go_c()
            {
                 Console.Write("c");
            }
            void Go_d()
            {
                 Console.Write("d");
            }
            void Go_e()
            {
                 Console.Write("e");
            }
            Console.ReadKey();
        }
    }
}
