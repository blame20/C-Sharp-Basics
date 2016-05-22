using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string binaryResult = "";

            while (decimalNumber >= 1)
            {
                binaryResult = (decimalNumber % 2) + binaryResult;
                decimalNumber /= 2;
            }
            Console.WriteLine(binaryResult);
        }
    }
}
