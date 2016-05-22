using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {
        public static int Fibo (int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci: ");
            Console.WriteLine(Fibo(n));
        }
    }
}
