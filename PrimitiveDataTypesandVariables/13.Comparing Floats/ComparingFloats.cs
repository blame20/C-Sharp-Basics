using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that safely compares floating-point numbers(double) with precision eps = 0.000001. 
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the 
//nature of the floating-point arithmetic.Therefore, we assume two numbers are equal if they are
//more closely to each other than a fixed constant eps. Examples:

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number a: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number b: ");
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool checkNumbers = Math.Abs(numberA - numberB) < eps;

            if (Math.Abs(numberA - numberB) <= eps)
            {
                Console.WriteLine(checkNumbers);
            }
            else if (Math.Abs(numberA - numberB) >= eps)
            {
                Console.WriteLine(checkNumbers);
            }
        }
    }
}