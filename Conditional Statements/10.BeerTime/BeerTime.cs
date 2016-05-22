using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time in format \"hh:mm tt\" (Example: 04:35 PM)");
            DateTime time = DateTime.Parse(Console.ReadLine());
            int hour = time.TimeOfDay.Hours;

            if ((hour >= 13 && hour <= 24) || (hour >= 0 && hour <= 3))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
