using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Num(word);
        }
        public static int Num(string word)
        {
            int max = 1;
            int maxNums = 0;
            for (int i = 1; i < word.Length - 1; i++)
            {
                max++;
                if (maxNums < max)
                {
                    maxNums = max;
                }
                if (word[i] != word[i + 1])
                {
                    max = 1;
                }

            }
            return maxNums;
        }
        
    }
}
