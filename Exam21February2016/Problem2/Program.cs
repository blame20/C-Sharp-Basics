using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;
            int counterC = 0;
            int counterD = 0;
            char a = 'a';

            for (int i = 0; i < n; i++)
            {
                n = int.Parse(Console.ReadLine());


                if (n % 4 == 0)
                {
                    a++;
                    counterA++;
                }
                else if (n % 4 == 1)
                {


                    counterB++;
                }
                else if (n % 4 == 2)
                {


                    counterC++;
                }
                else if (n % 4 == 3)
                {


                    counterD++;
                }
            }
        }
    }
}



