using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            double receiveMoney = double.Parse(Console.ReadLine());
            double dollarsExchanged = double.Parse(Console.ReadLine());
            double pizzaPrice = double.Parse(Console.ReadLine());
            double lasagnaPrice = double.Parse(Console.ReadLine());
            double sandwichPrice = double.Parse(Console.ReadLine());

            int pizzaQuant = int.Parse(Console.ReadLine());
            int lasagnaQuant = int.Parse(Console.ReadLine());
            int sandwichQuant = int.Parse(Console.ReadLine());

            pizzaPrice /= dollarsExchanged;
            lasagnaPrice /= dollarsExchanged;
            sandwichPrice /= dollarsExchanged;

            double moneyNeedsToEat = (pizzaPrice * pizzaQuant) + (lasagnaPrice * lasagnaQuant) +
                (sandwichPrice * sandwichQuant);

            if (receiveMoney > moneyNeedsToEat)
            {
                double moneyLeft = receiveMoney - moneyNeedsToEat;
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.",moneyLeft);
            }
            else
            {
                double moneyNeed = moneyNeedsToEat - receiveMoney;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.",moneyNeed);
            }
        }
    }
}
