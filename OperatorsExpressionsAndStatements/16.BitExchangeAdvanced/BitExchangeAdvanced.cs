using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// NOT MY DESICION! NOT MY DESICION! NOT MY DESICION!
/// </summary>

namespace _16.BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var mask = 0;

            if (Math.Max(p, q) + k > 32)
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Min(p, q) + k > Math.Max(p, q))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                while (k > 0)
                {
                    k--;
                    mask += (int)Math.Pow(2, k);
                }

                long firstBits = mask << p;
                long secondBits = mask << q;
                long checkFirst = n & firstBits;
                long checkSecond = n & secondBits;
                long change = (n & ~firstBits) & ~secondBits;
                long changeFirstBits = (checkFirst >> p) << q;
                long changeSecondBits = (checkSecond >> q) << p;
                long result = (change | changeFirstBits) | changeSecondBits;

                Console.WriteLine("Binary representation of n: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("Binary result:              {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("Result:                     {0}", result);

                Console.WriteLine("\n\n");

            }
        }
    }
}
