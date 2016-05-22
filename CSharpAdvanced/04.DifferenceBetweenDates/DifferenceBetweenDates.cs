using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            IFormatProvider timeFormat = new CultureInfo("bg-BG", true);

            DateTime firstDate = DateTime.Parse(Console.ReadLine(), timeFormat);
            DateTime secondDate = DateTime.Parse(Console.ReadLine(), timeFormat);

            TimeSpan daysBetween = secondDate - firstDate;
            Console.WriteLine();
            Console.WriteLine(daysBetween.Days);
        }
    }
}
