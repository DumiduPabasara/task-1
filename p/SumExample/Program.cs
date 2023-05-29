using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumExample
{
    internal class Program
    {
        public void addition(int a ,int b)
        {
            int c = a + b;
            Console.WriteLine( c);
        }

            
        static void Main(string[] args)
        {
            Program c1 = new Program();
            c1.addition(30, 10);


        }
    }
}
