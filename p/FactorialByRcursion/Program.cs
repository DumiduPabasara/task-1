using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FactorialByRcursion
{
    class Program
    {
        public int checkFact(int n)
        {
            if (n == 0)
                return 1;

            else
                return (n * checkFact(n - 1));
        }
        static void Main(string[] args)
        {
            int value = 5;
            int ret;
          Program pr = new Program();
            ret = pr.checkFact(value);

            Console.WriteLine("value is :{0}", ret);
            Console.WriteLine();

        }
    }
}
