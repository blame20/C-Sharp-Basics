using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintDeck52Cards
{
    class PrintDeck52Cards
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char spade = '\u2660';
            char heart = '\u2665';
            char diamond = '\u2666';
            char club = '\u2663';

            char[] suit = { club, diamond, heart, spade };
            string[] face = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int j = 0; j < face.Length; j++)
            {
                for (int i = 0; i < suit.Length; i++)
                {
                    Console.Write("{0,3}{1} ", face[j], suit[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
