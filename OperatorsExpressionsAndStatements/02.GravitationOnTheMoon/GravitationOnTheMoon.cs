using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOfAManOnMoon = 0.17;
            double weightOnTheMoon = weight * weightOfAManOnMoon;

            Console.WriteLine(weightOnTheMoon);
        }
    }
}
