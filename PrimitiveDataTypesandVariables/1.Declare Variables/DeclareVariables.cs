using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long,
//ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to
//ensure it will fit in it.Try to compile the code.Submit the source code of your Visual Studio project as part of your
//homework submission.

namespace _1.Declare_Variables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            sbyte firstVariable = -115;
            byte secondVariable = 97;
            ushort thirdVariable = 52130;
            short forthVariable = -10000;
            uint FiveVariable = 4825932;

            Console.WriteLine("sbyte:{0} byte:{1} ushort:{2} short:{3} uint:{4}", firstVariable, secondVariable,    
                             thirdVariable, forthVariable, FiveVariable);
        }
    }
}
