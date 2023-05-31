using System;
using System.Runtime.Remoting;

namespace FabonacciNo
{
     class Program
    {
        static void Main(string[] args)
        {
            int firstNo = 0;
            int secondNo = 1;
            int sum = 0;
            int evenSum = 0;

            while (sum < 4000)
            {
                sum = firstNo + secondNo;

                firstNo = secondNo;
                secondNo = sum;

                if (sum % 2 == 0)
                {
                    evenSum = evenSum + sum;
                }
            }
            Console.WriteLine(evenSum);
                
        }
    }
}

//check following for more optimize code
//int limit = 4000;
//int sum = 0;
//int first = 1;
//int second = 2;

//while (second <= limit)
//{
//    if (second % 2 == 0)
//    {
//        sum += second;
//    }

//    int next = first + second;
//    first = second;
//    second = next;
//}

//Console.WriteLine("Sum of even Fibonacci numbers: " + sum);
