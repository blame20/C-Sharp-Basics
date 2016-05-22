using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterArea
{
    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Console.Write("r= ");
            double r = double.Parse(Console.ReadLine());
            double p = 2 * (Math.PI) * r;
            double s = Math.PI * (r * r);
            Console.WriteLine("Perimeter is: {0:F2}", p);
            Console.WriteLine("Area is: {0:F2}", s);
        }
    }
}
