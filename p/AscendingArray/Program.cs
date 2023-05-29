using System;
using System.Security.Cryptography;

namespace AscendingArray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 32, 12, 15, 34, 6, 9, 45, 25, 20,10 };
            int temp;

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
             foreach(int item in arr)
            {
                Console.WriteLine(item + "");
            }
        }
    }
}
