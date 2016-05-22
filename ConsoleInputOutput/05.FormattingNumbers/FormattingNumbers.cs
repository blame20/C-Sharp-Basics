using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 0 && a <= 500)
            {
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("\n");
                Console.Write("|{0,-10:X}", a);

                string inBin = Convert.ToString(a, 2);

                Console.Write("|{0,0}|", inBin.PadLeft(10, '0'));
                Console.Write("{0,10:F2}|", b);
                Console.WriteLine("{0,-10:F3}|", c);

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

