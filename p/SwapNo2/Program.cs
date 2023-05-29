using System;


namespace SwapNo2
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            a = a+b;
            b = a-b;
            a = a-b;

            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);

        }
    }
}
