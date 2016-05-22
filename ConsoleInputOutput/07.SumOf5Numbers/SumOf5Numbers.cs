using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            double a = double.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);
            double d = double.Parse(numbers[3]);
            double e = double.Parse(numbers[4]);

            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, a+b+c+d+e);
        }
    }
}
