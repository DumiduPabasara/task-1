using System;


namespace PallidromNo
{
     class Program
    {
        static void Main(string[] args)
        {
            int no = 153;
            int originalNo = no;
            int sum = 0;
            int reminder = 0;

         while(no>0)
            {
                reminder = no % 10;
                sum = sum * 10 + reminder;
                no = no / 10;

            }
              if(originalNo == sum)
            {
                Console.WriteLine(" The Number is Pallidrom ");
            }
            else
            {
                Console.WriteLine(" The no is not Pallidrom ");
            }
        }
    }
}
