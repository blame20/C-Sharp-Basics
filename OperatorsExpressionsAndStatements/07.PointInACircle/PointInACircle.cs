using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool inside;
            double sqrt = Math.Sqrt(x * x + y * y);

            if (sqrt <= 2)
            {
                inside = true;
                Console.WriteLine(inside + "\n" + "The point is inside a circle");
            }
            else
            {
                inside = false;
                Console.WriteLine(inside + "\n" + "The point is not inside a circle");
            }
        }
    }
}
