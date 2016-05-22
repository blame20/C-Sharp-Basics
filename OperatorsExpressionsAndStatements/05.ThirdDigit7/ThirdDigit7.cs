using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigit7
{
    class ThirdDigit7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool thirdDigitIs7 = (n / 100) % 10 == 7 ;
            
            Console.WriteLine("{0} <---", n);
            Console.WriteLine(thirdDigitIs7);
        }
    }
}
