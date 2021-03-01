/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');
            Console.Clear();
            int[] numbers = new int[values.Length];
            for (int i = 0 ; i < values.Length ; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }
            for (int i = 0 ; i < numbers.Length ; i++)
            {
                SortDescending(numbers);
                Console.Write($"{numbers[i]}, ");
            }
            
        }
        static void SortDescending(int[] a)
        {
            for (int j = 0 ; j <= a.Length - 2 ; j++ ){
                for (int i = 0 ; i <= a.Length - 2 ; i++)
                {
                    if (a[i] <= a[i + 1])
                    {
                        int t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
        }
    }
}
