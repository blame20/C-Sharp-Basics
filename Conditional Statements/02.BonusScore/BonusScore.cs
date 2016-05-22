using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            int result;

            if (score >= 1 && score <= 3)
            {
                result = score *= 10;
                Console.WriteLine();
                Console.WriteLine(result);
            }
            else if (score >= 4 && score <= 6)
            {
                result = score *= 100;
                Console.WriteLine();
                Console.WriteLine(result);
            }
            else if (score >= 7 && score <= 9)
            {
                result = score *= 1000;
                Console.WriteLine();
                Console.WriteLine(result);
            }
            else if (score <= 0 || score > 9) 
            {
                Console.WriteLine();
                Console.WriteLine("invalid score");
            }
        }
    }
}
