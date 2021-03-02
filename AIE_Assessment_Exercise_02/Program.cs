/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)//   <<???
        {
            if (args.Length < 1)
            {
                args = new string[] { "8" };
            }

            int numberOfElements = int.Parse(args[0]);
            for (int i = 0 ; i < numberOfElements ; i++)
            {
                Console.Write($"{Fibonacci(i)}, ");
            }
            // TODO: loop through elements and print them : DONE
        }
        static int Fibonacci(int a)
        {
            int[] Fib = new int[a + 2];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 0 ; i < a ; i++)
            {
                int temp = Fib[0];
                Fib[0] = Fib[1];
                Fib[1] = temp + Fib[0];
            }
            return Fib[0];


        }
    }
}

