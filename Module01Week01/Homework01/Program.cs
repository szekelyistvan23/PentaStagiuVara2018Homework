using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numar = random.Next(0, 100);

            Console.WriteLine("Ghiceste numarul la care m-am gandit");
            int x;
            do
            {
                Console.WriteLine("Introdu un numar:");
                string str = Console.ReadLine();
                x = int.Parse(str);

                if (x > numar)
                {
                    Console.WriteLine("Numarul tau este mai mare.");
                }
                else if (x < numar)
                {
                    Console.WriteLine("Numarul tau este mai mic.");
                }
            } while (x != numar);
            Console.WriteLine("Bravo! Ai ghicit numarul!");
        }
    }
}
