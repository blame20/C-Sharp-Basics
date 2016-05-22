using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            BigInteger divider = 1;

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            for (int i = 1; i <= n - k; i++)
            {
                divider *= i;
            }
            result /= divider;
            Console.WriteLine(result);
        }
    }
}
