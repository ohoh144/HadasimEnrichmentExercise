using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static bool IsSortedPalindrome(string input)
        {
            int n = input.Length, i = 0, j = n - 1;
            char prev = '\0';

            if (string.IsNullOrEmpty(input))
                return false; //If it's empty : return false. mathematically, an empty string is considered a palindrome: so if we will folow by mathematic rulls we should return True   
            
            while (i < j)
            {
                if (i > 0 && input[i] < prev)//i > 0 skips the first character since there is no previous character to compare with
                    return false;

                if (input[i] != input[j])
                    return false;

                prev = input[i];
                i++; j--;
            }

            if (i == j && i > 0 && input[i] < prev) //i > 0 skips the first character since there is no previous character to compare with
                return false;

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsSortedPalindrome("אבבא"));
            Console.ReadLine(); //Keep console window open to view the result
        }

    }
}
