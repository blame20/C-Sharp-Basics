using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find online more information about ASCII(American Standard Code for Information Interchange)
//and write a program to prints the entire ASCII table of characters at the console(characters from 0 to 255).
//Note that some characters have a special purpose and will not be displayed as expected.You may skip them or
//display them differently.You may need to use for-loops (learn in Internet how).

namespace _14.PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII Table: ");
            int min = 0;
            int max = 255;
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine("{0}-->{1}", i, (char)i);
            }
        
        }
    }
}
