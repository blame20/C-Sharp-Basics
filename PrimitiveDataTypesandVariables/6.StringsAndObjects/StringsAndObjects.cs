using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign
//it with the concatenation of the first two variables(mind adding an interval between). Declare a third string
//variable and initialize it with the value of the object variable(you should perform type casting).

namespace _6.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object firstObject = firstString + " " + secondString;
            string thirdString = firstObject as string;

            Console.WriteLine("{0} {1} {2} {3}", firstString, secondString, firstObject, thirdString);
        }
    }
}
