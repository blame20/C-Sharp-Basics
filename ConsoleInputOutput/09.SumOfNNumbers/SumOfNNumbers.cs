using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double numbers = double.MinValue;
            double sum = 0.00;
            for (int i = 0; i < n; i++)
            {
                numbers = double.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.Write("\n");
            Console.WriteLine(sum);
        }
    }
}
