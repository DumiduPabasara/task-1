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

//refer following code for checking palindrome with string values
/*     static void Main(string[] args)
    {
        string input = "madam";
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        bool isPalindrome = input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    } */