using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexResult = "";
            long currentResult = decimalNumber;

            StringBuilder result = new StringBuilder();

            while (decimalNumber > 0)
            {
                switch (decimalNumber % 16)
                {
                    case 10:
                        result.Insert(0, "A");
                        decimalNumber /= 16;
                        break;
                    case 11:
                        result.Insert(0, "B");
                        decimalNumber /= 16;
                        break;
                    case 12:
                        result.Insert(0, "C");
                        decimalNumber /= 16;
                        break;
                    case 13:
                        result.Insert(0, "D");
                        decimalNumber /= 16;
                        break;
                    case 14:
                        result.Insert(0, "E");
                        decimalNumber /= 16;
                        break;
                    case 15:
                        result.Insert(0, "F");
                        decimalNumber /= 16;
                        break;
                    default:
                        result.Insert(0, decimalNumber % 16);
                        decimalNumber /= 16;
                        break;
                }
            }
            
            hexResult = result.ToString();

            if (currentResult == 0)
            {
                hexResult = "0";
            }

            Console.WriteLine(hexResult);
        }
    }
}
