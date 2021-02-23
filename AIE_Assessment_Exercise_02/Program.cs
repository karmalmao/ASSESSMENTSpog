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
            int numberOfElements = 0; // integer: n

            if (args.Length < 1)
            {
                args = new string[] { "5" };
            }

            numberOfElements = Int32.Parse(args[0]);

            Fibonacci(numberOfElements); 
        }
        static int Fibonacci(int a)
        {
            int[] fib = new int[a];
            int b = 0;
            int c = 1;
            int d = 0;
            for (int i = 0 ; i <= fib.Length / 2  ; i++)
            {
                
                b = b + c;
                Console.WriteLine(c);
                c = b + c;
                Console.WriteLine(b);


            }
            return 0;
 //         0 1 1 2 3 5 8 13
 //         b c b c b c b  c
        }
    }
}
