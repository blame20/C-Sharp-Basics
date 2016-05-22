using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            int[] firstLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] secondLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            IEnumerable<int> numbersFind = firstLine.Union(secondLine);
            IEnumerable<int> numbersOrder = numbersFind.OrderBy(num => num);

            Console.WriteLine();
            foreach (var numbers in numbersOrder)
            {
                Console.Write("{0} ", numbers);
            }
            Console.WriteLine();
        }
    }
}
