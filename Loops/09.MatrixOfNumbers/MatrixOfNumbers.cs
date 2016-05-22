using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n ; col++)
                {
                    Console.Write("{0,2}",row + col);
                }
                Console.WriteLine();
            }
        }
    }
}
