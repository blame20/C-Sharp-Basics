using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Widht = ");
            double widht = double.Parse(Console.ReadLine());
            Console.Write("Height = ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (widht * 2) + (height * 2);
            double area = widht * height;
            Console.Write("\n");
            Console.WriteLine("Perimeter = {0}", perimeter);
            Console.WriteLine("Area = {0}", area);
        }
    }
}
