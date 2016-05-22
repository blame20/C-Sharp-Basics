using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            BigInteger evenProduct = 1;
            BigInteger oddProduct = 1;

            for (int i = 1; i <= numbers.Length; i++)
            {
                int currentNumber = Convert.ToInt32(numbers[i - 1]);

                if (i % 2 == 0)
                {
                    evenProduct *= currentNumber;
                }
                else
                {
                    oddProduct *= currentNumber;
                }                 
            }
            Console.WriteLine();

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes\nproduct = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no\noddproduct = {0}\neven product = {1}", oddProduct, evenProduct);
            }
        }
    }
}
