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

