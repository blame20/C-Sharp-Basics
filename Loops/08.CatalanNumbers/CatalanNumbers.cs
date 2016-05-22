using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger firstNumber = 1;
            BigInteger secondNumber = 1;

            for (int k = 2; k <= n; k++)
            {
                firstNumber *= n + k;
                secondNumber *= k;
            }
            BigInteger catalanNumber = firstNumber / secondNumber;

            Console.WriteLine("Catalan number is:\n{0}", catalanNumber);
        }
    }
}
