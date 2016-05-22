using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

namespace _5.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool isFemale = false;
            if (isFemale == false)
            {
                Console.WriteLine("I'm Male! \n{0}", isFemale);
            }
            else
            {
                Console.WriteLine(isFemale);
            }
        }
    }
}
