using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    class Swap
    {

        public static void SwapNumber(int number1,int number2)
        {
            Console.WriteLine($"Before Swap {number1} and {number2}");

            number1 += number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine($"After Swap {number1} and {number2}");
        }

    }
}
