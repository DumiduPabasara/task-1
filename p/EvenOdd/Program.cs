using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 20;

            if (a%2 == 0)
            {
                Console.WriteLine(a + " is Even Number");
            }
            else
            {
                Console.WriteLine(a + " is Odd Number");
            }
        }
    }
}
