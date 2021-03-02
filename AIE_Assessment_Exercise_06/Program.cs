/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            LoadWords("./words.txt" , words);
            SortWords(words);
            SaveWords("./output.txt" , words);

        }
        public static List<string> LoadWords(string path , List<string> list)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                int numofwords = int.Parse(sr.ReadLine());
                for (int i = 0 ; i < numofwords ; i++)
                {
                    list.Add(sr.ReadLine());
                }
                return list;
            }
        }
        public static void SortWords(List<string> words)
        {
            words.Sort();
        }
        public static void SaveWords(string path, List<string> words)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 1 ; i < words.Count ; i++)
                {
                    sw.WriteLine(words[i]);
                }
            }
        }

    }
}
