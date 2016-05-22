using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            //string [] input = Console.ReadLine().Split();

            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(); ;
        }
    }
}
