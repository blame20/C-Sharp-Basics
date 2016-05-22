using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesGivenRange
{
    class PrimesGivenRange
    {

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> FindPrimesInRange = new List<int>();

            if (startNum < 2)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                bool IsPrime = true;

                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime)
                {
                    FindPrimesInRange.Add(i);
                }
            }
            return FindPrimesInRange;
        }

        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNum);

            if (primes.Count == 0)
            {
                Console.WriteLine("\n(empty list)\n");
            }
            else if (startNum > endNum)
            {
                Console.WriteLine("\n(empty list)\n");
            }

            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i]);
                if (i == primes.Count - 1)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
