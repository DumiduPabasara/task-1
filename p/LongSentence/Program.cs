using System;
using System.Collections.Generic;


namespace LongSentence
{
     class Program
    {

        

        static int LongestWordLength(string str)
        {
            int n = str.Length;
            int res = 0, curr_len = 0;
            for (int i = 0; i < n; i++)
            {

             
                if (str[i] != ' ')
                    curr_len++;

              
                else
                {
                    res = Math.Max(res, curr_len);
                    curr_len = 0;
                }
            }

       
            return Math.Max(res, curr_len);
        }

        public static void Main()
        {
            string s = "Every programmer is an Auther";
            Console.Write(LongestWordLength(s));
        }
    }

    
    }

    //refer this code also alternative way
/*         static void Main(string[] args)
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        string[] words = sentence.Split(' ');
        string longestWord = "";
        int maxLength = 0;

        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
                longestWord = word;
            }
        }

        Console.WriteLine("Longest word: " + longestWord);
        Console.WriteLine("Length: " + maxLength);
    } */

