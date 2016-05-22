using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Which of the following values can be assigned to a variable of type float and which to a variable of type 
//double: 34.567839023,12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables 
//and print them to ensure no precision is lost.


namespace _2.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double firstVariable = 34.567839023;
            float secondVariable = 12.345f;
            double thirthVariable = 8923.1234857;
            float forthVariable = 3456.091f;

            Console.WriteLine("{0} {1} {2} {3}", firstVariable, secondVariable, thirthVariable, forthVariable);
                
        }
    }
}
