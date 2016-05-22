using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitGivenPosition
{
    class CheckBitGivenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bit = n >> p & 1;
            bool bitPosition = false;
            if (bit == 1)
            {
                bitPosition = true;
                Console.WriteLine(bitPosition);
            }
            else
            {
                Console.WriteLine(bitPosition);
            }
        }
    }
}
