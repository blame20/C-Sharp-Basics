using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isDivide7And5 = n % 35 == 0;

            Console.WriteLine(isDivide7And5);
        }
    }
}
