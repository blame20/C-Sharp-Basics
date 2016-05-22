using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names = input.Split(' ').ToList();

            string removeInput = Console.ReadLine();
            List<string> removeNames = removeInput.Split(' ').ToList();

            for (int i = 0; i < removeNames.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (names.Contains(removeNames[i]))
                    {
                        names.Remove(removeNames[i]);
                    }
                }
            }
            Console.WriteLine();
            //Console.WriteLine(string.Join<string>(" ", names));
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
