/*
 * Appendix1 - Exercise 3: FizzBuzz
 */

using System;

namespace AIE_Assessment_Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                args = new string[] { "16" };
            }

            int numberOfElements = int.Parse(args[0]);
            FizzBuzz(numberOfElements);
        }
        static void FizzBuzz(int a)
        {

            for (int i = 1 ; i <= a ; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(" FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(" Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(" Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
