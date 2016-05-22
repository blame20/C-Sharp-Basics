using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Please enter a integer:");
                    int intNum = int.Parse(Console.ReadLine());
                    intNum += 1;
                    Console.WriteLine();
                    Console.WriteLine(intNum);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Please enter a double:");
                    double doubleNum = double.Parse(Console.ReadLine());
                    doubleNum += 1;
                    Console.WriteLine();
                    Console.WriteLine(doubleNum);
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Please enter a string:");
                    string str = Console.ReadLine();
                    Console.WriteLine();
                    str += "*";
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }
}
