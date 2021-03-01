/*
 * Appendix 2 - Exercise 1: Sum of Array
 */

using System;

namespace AIE_Assessment_Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }

            Console.WriteLine(SumNumbers(numbers));
        }
        static int SumNumbers(int[] numbers)
        {
            int total = 0;
            for (int i = 0 ; i < numbers.Length ; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }
    }
}
