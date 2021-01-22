using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    // This program is to test basic programming skiils 

    /*
     * Implementation of FizzBuzz involves printing numbers from 1 to 100. If the numbers are multiples of 3 then Fizz is printed.
     * If they are multiples of 5, then Buzz is printed and if they are multiples of both 3 and 5 then FizzBuzz is printed.     * 
     */
    class FizzBuzz
    {


        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Logic1(i);
                Logic2(i);
                Console.WriteLine();
            }
        }

        static void Logic1(int i)
        {

            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(i);
            }
        }

        static void Logic2(int i)
        {
            bool NoSucess = false;
            if ((NoSucess = (i % 3) == 0))
            {
                Console.Write("Fizz");
            }

            if ((NoSucess = (i % 5) == 0))
            {
                Console.Write("Buzz");
            }

            if (NoSucess == false)
                Console.Write(i);
        }
    }
}
