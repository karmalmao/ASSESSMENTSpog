/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.IO;
using System.Linq;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = File.OpenText("./words.txt")) {
                int test = int.Parse(sr.ReadLine());

                string[] save = new string[test];

                for (int i = 1 ; i < save.Length ; i++)
                {
                    save[i] = sr.ReadLine();
                }
                Array.Sort(save);
                using (StreamWriter sw = File.CreateText("./output.txt"))
                {
                    for (int i = 1 ; i < save.Length ; i++)
                    {
                        string str = save[i];
                        sw.WriteLine(str);
                    }
                }









               
            }
        }
    }
}
