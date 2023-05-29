using System;

namespace Sum1to100
{
     class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i =1; i<=100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
