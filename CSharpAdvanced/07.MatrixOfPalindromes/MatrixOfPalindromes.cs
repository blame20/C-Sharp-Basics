using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write("{0}{1}{0} ", (char)('a' + row), (char)('a' + col + row));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
