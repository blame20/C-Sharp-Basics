using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            uint start = uint.Parse(Console.ReadLine());
            uint end = uint.Parse(Console.ReadLine());
            int p = 0;

            for (uint i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("p = {0}", p);
        }
    }
}
