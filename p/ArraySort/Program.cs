using System;


namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 23, 15, 30, 50, 49, 25 };
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j =i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
              Console.WriteLine("large No = " + arr[arr.Length - 1]);
            Console.WriteLine("Smallest No = " + arr[0]);
        }
    }
}