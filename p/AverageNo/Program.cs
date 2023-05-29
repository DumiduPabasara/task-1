using System;


namespace AverageNo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;

            Console.WriteLine(" Enter 1st Number : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter 2nd Number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter 3rd Number : ");
            num3= Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3;

            Console.WriteLine("\n The Average is : " + average);
            Console.ReadLine();




        }
    }
}
