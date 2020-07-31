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

            Array.Reverse(userCharArray);

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


        }
    }
}
