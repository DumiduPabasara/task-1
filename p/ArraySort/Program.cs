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

//Code is correct. refer following code for how to find min max using .NET library functions defined in LINQ
/*     static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 9, 1, 7 };

        int smallest = numbers.Min();
        int largest = numbers.Max();

        Console.WriteLine("Smallest number: " + smallest);
        Console.WriteLine("Largest number: " + largest);
    } */