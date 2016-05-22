using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int bitPosition = (binaryNumber.Length - 1) - i;

                if (binaryNumber[bitPosition] == '1')
                {
                    decimalNumber += (long)Math.Pow(2, i);
                }
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
