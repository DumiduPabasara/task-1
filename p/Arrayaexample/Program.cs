using System;
using System.Collections.Generic;

namespace Arrayaexample
{
     class Program
    {

        
        public static void countFreq(int[] arr, int n)
        {
            bool[] a = new bool[n];

        
            for (int i = 0; i < n; i++)
            {

                
                if (a[i] == true)
                    continue;

                
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        a[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);
            }
        }

        
        public static void Main(String[] args)
        {
            int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
            int n = arr.Length;
            countFreq(arr, n);
        }
    }
 
    }

    //This code is correct, refer below code for more optimized one, you can use a Dictionary set instead of bool array

/*         static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 5, 1, 7, 2, 5 };
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number]++;
            }
            else
            {
                frequencyMap[number] = 1;
            }
        }

        Console.WriteLine("Element - Frequency");
        foreach (var kvp in frequencyMap)
        {
            Console.WriteLine(kvp.Key + " - " + kvp.Value);
        }
    } */

