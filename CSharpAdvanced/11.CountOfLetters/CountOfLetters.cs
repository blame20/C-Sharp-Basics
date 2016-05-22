using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            char[] input = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);

            for (char letters = 'a'; letters <= 'z'; letters++)
            {
                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (letters == input[i])
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    Console.WriteLine("{0} -> {1}", letters, counter);
                }
            }
            Console.WriteLine();
        }
    }
}
