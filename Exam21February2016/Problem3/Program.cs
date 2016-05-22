using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n * 2;
            int middleDots = 2;
            int leaves = 1;

            Console.WriteLine("##{0}##{0}##", new string('.', dots));
            for (int i = 0; i < n - 1; i++)
            {
                dots -= 2;
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', leaves), new string('.', dots), new string('.', middleDots));
                middleDots += 2;
                leaves++;
            }
            dots--;
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', dots), new string('~', leaves), new string ('.', middleDots));
            for (int i = 0; i < n; i++)
            {
                dots += 2;
                leaves--;
                middleDots -= 2;
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', dots), new string('~', leaves), new string('.', middleDots));
            }
            dots++;
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine("{0}##{0}", new string ('.', dots));
            }
        }
    }
}
