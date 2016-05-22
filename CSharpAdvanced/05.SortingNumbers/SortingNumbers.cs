using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class SortingNumbers
    {
        static int[] Sort(params int[] numbers)
        {
            // The sorting logic:
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop operating over the unsorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int [n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Sort(numbers);
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
               Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
