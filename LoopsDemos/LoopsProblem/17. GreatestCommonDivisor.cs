using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        // Input
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());

        // Exchange values if a < b
        if (a < b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        // Main Logic
        double result;
        double resultRemainder;

        Console.WriteLine();
        while (true)
        {
            result = a / b;
            resultRemainder = a % b;
            if (resultRemainder != 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; remainder = {3}", a, b, result, resultRemainder);
                a = b;
                b = resultRemainder;
            }
            else
            {
                Console.WriteLine("{0} : {1} = {2} ; remainder = {3}", a, b, result, resultRemainder);
                Console.WriteLine("The Greatest Common Divisor is: {0}", b);
                break;
            }
        }
    }
}