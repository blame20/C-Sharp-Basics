using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}", b, a);
            }
            if (a < b)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}", a, b);
            }
            if (a == b)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
