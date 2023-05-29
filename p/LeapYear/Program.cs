using System;


namespace LeapYear
{
     class Program
    {
        static void Main(string[] args)
        {
            int year = 2023;

            if((year%400==0) || (year%4==0 && year % 100 != 0))
            {
                Console.WriteLine(" This is Leap Year");

            }
            else
            {
                Console.WriteLine("This is not Leap Year");
            }
        }
    }
}
