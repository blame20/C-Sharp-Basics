using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersGivenRange
{
    class RandomNumbersGivenRange
    {
        static void Main(string[] args)
        {
            int min = Int32.MinValue;
            int max = Int32.MaxValue;
            int n = int.Parse(Console.ReadLine());

            min = int.Parse(Console.ReadLine());

            max = int.Parse(Console.ReadLine());

            Random randomNum = new Random();

            for (int i = 0; i < n; i++)
            {
                if (min < max)
                {
                    Console.Write("{0} ", randomNum.Next(min, max + 1));
                }
                else
                {
                    Console.Write("The number is not valid. Min < Max! ");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
