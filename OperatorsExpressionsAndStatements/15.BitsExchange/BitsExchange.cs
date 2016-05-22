using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            uint bit345 = n & 0x00000038;
            uint bit242526 = n & 0x07000000;

            uint result = n & ~(uint)(0x00000038 | 0x07000000);

            result |= bit345 << 21;
            result |= bit242526 >> 21;

            Console.Write("\n");
            Console.WriteLine(result); 
        } 
    }
}
