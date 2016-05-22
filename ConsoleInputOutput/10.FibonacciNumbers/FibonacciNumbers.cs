using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong a = 0;
            ulong b = 1;
            ulong temp = 0;

            for (ulong i = 0; i < n; i++)
            {
                b = temp + b;
                Console.Write("{0}" + " ", a, b);
                temp = a;
                a = b;
            }
            Console.Write("\n");
        }
    }
}
