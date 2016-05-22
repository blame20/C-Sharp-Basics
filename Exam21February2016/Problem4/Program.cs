using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            int counter = 0;

            while (line == "mall.Enter" && line != "mall.Exit")
            {
                line = Console.ReadLine();
                char currentChar = line[0];
                counter += currentChar / currentChar;

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    n = n - (currentChar % 70);
                    Console.WriteLine("{0} purchases. Money left: {1} lv.", counter, n);
                }

                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    n = n / (currentChar % 50);
                    Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", counter, n);
                }
                else if (currentChar == '%')
                {
                    n = n - (currentChar + 18);
                    Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", counter, n);
                }
                else if (currentChar == '*')
                {
                    n = n - (currentChar - 10);
                    Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", counter, n);
                }
                else
                {
                    n = n - (currentChar);
                    Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", counter, n);
                }
            }    
        }
    }
}
