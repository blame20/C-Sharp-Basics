using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            if (k < 2 || k > 99)
            {
                Console.WriteLine("Number is not valid.");
            }
            else if (n <= k || n > 99)
            {
                Console.WriteLine("Number is not valid.");
            }
            for (int i = 0; i < n - k; i++)
            {
                result *= (k + 1) + i;
            }
            Console.WriteLine(result);
        }
    }
}
