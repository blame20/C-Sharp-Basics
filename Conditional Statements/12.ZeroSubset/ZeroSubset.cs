using System;

class Program
{
    static void Main()
    {
        ulong resultNumber = 0;
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber)
        {
            ulong mask = 1;
            int longCurrentPos = 63;
            for (int bit = 31; bit >= 0; bit--)
            {
                ulong extractedBit = (firstNumber & (mask << bit)) >> bit;
                resultNumber = resultNumber | (extractedBit << longCurrentPos);

                longCurrentPos--;

                extractedBit = (secondNumber & (mask << bit)) >> bit;
                resultNumber = resultNumber | (extractedBit << longCurrentPos);

                longCurrentPos--;
            }
        }
        else
        {
            ulong mask = 3;
            int longCurrentPos = 62;
            for (int bit = 30; bit >= 0; bit -= 2)
            {
                ulong extractedBit = (firstNumber & (mask << bit)) >> bit;
                resultNumber = resultNumber | (extractedBit << longCurrentPos);

                longCurrentPos -= 2;

                extractedBit = (secondNumber & (mask << bit)) >> bit;
                resultNumber = resultNumber | (extractedBit << longCurrentPos);

                longCurrentPos -= 2;
            }
        }

        Console.WriteLine(resultNumber);
    }
}

