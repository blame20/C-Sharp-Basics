using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            long decimalResult = 0;

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                char hexSymbol = hexadecimalNumber[hexadecimalNumber.Length - 1 - i];

                switch (hexSymbol)
                {
                    case '1':
                        decimalResult += (long)(1 * (Math.Pow(16, i)));
                        break;
                    case '2':
                        decimalResult += (long)(2 * (Math.Pow(16, i)));
                        break;
                    case '3':
                        decimalResult += (long)(3 * (Math.Pow(16, i)));
                        break;
                    case '4':
                        decimalResult += (long)(4 * (Math.Pow(16, i)));
                        break;
                    case '5':
                        decimalResult += (long)(5 * (Math.Pow(16, i)));
                        break;
                    case '6':
                        decimalResult += (long)(6 * (Math.Pow(16, i)));
                        break;
                    case '7':
                        decimalResult += (long)(7 * (Math.Pow(16, i)));
                        break;
                    case '8':
                        decimalResult += (long)(8 * (Math.Pow(16, i)));
                        break;
                    case '9':
                        decimalResult += (long)(9 * (Math.Pow(16, i)));
                        break;
                    case 'A':
                    case 'a':
                        decimalResult += (long)(10 * (Math.Pow(16, i)));
                        break;
                    case 'B':
                    case 'b':
                        decimalResult += (long)(11 * (Math.Pow(16, i)));
                        break;
                    case 'C':
                    case 'c':
                        decimalResult += (long)(12 * (Math.Pow(16, i)));
                        break;
                    case 'D':
                    case 'd':
                        decimalResult += (long)(13 * (Math.Pow(16, i)));
                        break;
                    case 'E':
                    case 'e':
                        decimalResult += (long)(14 * (Math.Pow(16, i)));
                        break;
                    case 'F':
                    case 'f':
                        decimalResult += (long)(15 * (Math.Pow(16, i)));
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
            Console.WriteLine(decimalResult);
        }
    }
}
