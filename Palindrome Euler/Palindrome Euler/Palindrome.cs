using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Euler
{
    class Palindrome
    {
        public Palindrome()
        {
            
        }

        public static bool pDrome(int number)
        {
            int numLength = number.ToString().Length;
            string numString = number.ToString();

                int j = numLength;
                for (int i = 0; i < numLength / 2; i++)
                {
                    

                    int num1 = (int)char.GetNumericValue(numString[i]);
                    int num2 = (int)char.GetNumericValue(numString[j-1]);

                    if (num1 != num2)
                    {
                        return false;
                    }
                    j--;
                }
            return true;
        }

        public int calculatePDrome(int num1, int num2)
        {
            int pDromePass = num1 * num2;

            if(Palindrome.pDrome(pDromePass))
            {
                return pDromePass;
            }
            else
            return 0;
        }
    }
}
