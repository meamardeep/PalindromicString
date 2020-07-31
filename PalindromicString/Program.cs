using System;
using System.Text;

namespace PalindromicString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string userString = Console.ReadLine();

            //Check Palindome using in-built Array.Reverse() method
            Palindrome.PalindromeWithInBuiltFunction(userString);
//Palindrome.PalindromeWithoutInBuiltFunction(userString);
            Console.ReadLine();
            //
        }
    }
}
