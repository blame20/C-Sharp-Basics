using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverageOfNNumbers
{
    class MinMaxSumAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.Write("The number is not valid: ");
            }

            int maxNum = Int32.MinValue;
            int minNum = Int32.MaxValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number [{0}]: ", i + 1);
                int currentNum;

                while (!int.TryParse(Console.ReadLine(), out currentNum))
                {
                    Console.Write("The number is not valid: ");
                }

                maxNum = Math.Max(maxNum, currentNum);
                minNum = Math.Min(minNum, currentNum);
                sum += currentNum;
            }

            double average = (double)sum / n;

            Console.WriteLine("\nmin = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}\n",
                minNum, maxNum, sum, average);
        }
    }
}
