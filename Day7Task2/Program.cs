using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;
            Fibonacci f = new Fibonacci();
            Console.WriteLine("press (Esc) key to exit");
            Console.WriteLine("press somthig else to get one more number");
            foreach(int i in f)
            {
                cki = Console.ReadKey();
                if ((cki.Key == ConsoleKey.Escape))
                    break;
                Console.WriteLine("{0}",i.ToString());
            }
        }
    }
}
