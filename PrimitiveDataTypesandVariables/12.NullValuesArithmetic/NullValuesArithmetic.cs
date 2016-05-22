using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.Try to add some number or the null
//literal to these variables and print the result.

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null;
            double? floatNumber = null;
            Console.WriteLine("Null value: " + nullableInteger);
            Console.WriteLine("Null value: " + floatNumber);

            nullableInteger += 9;
            floatNumber += 3.5;
            Console.WriteLine("Number + null value: " + nullableInteger);
            Console.WriteLine("Number + null value: " + floatNumber);

            nullableInteger = 9;
            floatNumber = 3.5;
            Console.WriteLine("Number value: " + nullableInteger);
            Console.WriteLine("Number value: " + floatNumber);
        }
    }
}
