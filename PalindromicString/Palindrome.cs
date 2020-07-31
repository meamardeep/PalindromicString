using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromicString
{
    static class Palindrome
    {
        public static void PalindromeWithInBuiltFunction(string userString)
        {            
            char[] userCharArray = userString.ToCharArray();

            Array.Reverse(userCharArray); // reverse string will be assigned to userCharArray[]

            StringBuilder sb = new StringBuilder();
            foreach (var item in userCharArray)
            {
                sb.Append(item);
            }

            if (sb.ToString() == userString)
                Console.WriteLine("Given string is palindrome");
            else
                Console.WriteLine("Given string is not a palindrome");            
        }

        public static void PalindromeWithoutInBuiltFunction(string userString)
        {
            int length = userString.Length - 1;
            string reverseString = "";
            while(length >= 0 )
            {
                reverseString = reverseString + userString[length];
                length =  length - 1;
            }

            if (reverseString == userString)
                Console.WriteLine("Given string is palindrome");
            else
                Console.WriteLine("Given string is not palindrome");         
        }



    }
}
