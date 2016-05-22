using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {
        public static bool IsPrime(ulong n)
        {
            bool prime = true;

            if (n < 2)
            {
                prime = false;
            }
            for (ulong i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }

        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }
    }
}
