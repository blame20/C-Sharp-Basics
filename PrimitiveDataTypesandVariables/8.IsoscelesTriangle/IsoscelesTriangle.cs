using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

namespace _8.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            char copyRight = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("   {0}   \n  {0} {0}  \n {0}   {0} \n{0} {0} {0} {0}", copyRight);
        }
    }
}
