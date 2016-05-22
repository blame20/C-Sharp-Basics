using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {

            string[] units = new string[] { "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ",                              "Nine ", "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Forteen ", "Fifteen ",
                     "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };

            string[] tens = new string[] { "Ten ", "Twenty ", "Thirthy ", "Forty ", "Fifty ",
                                           "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            int i, num;
            string result = "";

           // Console.WriteLine("Enter number here in range 1-999 : ");

            num = int.Parse(Console.ReadLine());

            if (num > 99 && num < 1000)
            {
                i = num / 100;
                result = units[i - 1] + "Hundred ";
                num = num % 100;
            } 
            if (num > 19 && num < 100)
            {
                i = num / 10;
                result = result + tens[i - 1];
                num = num % 10;
            }
            if (num < 20 && num > 0)
            {
                result += units[num - 1];
            }

            Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}




