using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 1)
            {
                Console.WriteLine("The number is odd! {0}", n);
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("The number is even! {0}", n);
            }
        }
    }
}
