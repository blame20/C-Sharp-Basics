using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisible3and7
{
    class NumbersNotDivisible3and7
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
