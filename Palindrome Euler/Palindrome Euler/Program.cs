using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome check = new Palindrome();

            int palin = 50015005;
            //Palindrome.pDrome(palin);
            Console.WriteLine("Checking for Palindromes");
            int largestPalindrome = 0;
            int temp = 0;

            for(int i = 12; i < 999; i++)
            {
                for (int j = 12; j < 999; j++)
                {
                    temp = check.calculatePDrome(i, j);
                    if (temp >= largestPalindrome)
                    {
                        largestPalindrome = temp;
                        Console.WriteLine("Current Largest Palindrome: " + largestPalindrome + " Multiplication of " + i + " x " + j);
                    }
                }
            }
            Console.WriteLine("Largest Palindrome: " + largestPalindrome);
            Console.ReadLine();
        }
    }
}
