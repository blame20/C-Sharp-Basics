using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 0;
            BigInteger start = 1;

            while (n >= start)
            {
                start *= 5;
                result += n / start;
            }
            Console.WriteLine("Trailing zeroes in N!:\n{0}",result);
        }
    }
}
