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
