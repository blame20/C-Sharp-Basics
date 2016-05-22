using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;

            int sumOfDigit = a + b + c + d;
            int reverse = d * 1000 + c * 100 + b * 10 + a;
            int LastDigitInFront = d * 1000 + a * 100 + b * 10 + c;
            int ExchangesSecondAndThird = a * 1000 + c * 100 + b * 10 + d;

            Console.WriteLine("Sum of digit is: " + sumOfDigit);
            Console.WriteLine("Number reversed: " + reverse);
            Console.WriteLine("Last digit in front: " + LastDigitInFront);
            Console.WriteLine("Exchanges the second and third digit: " + ExchangesSecondAndThird);
        }
    }
}
