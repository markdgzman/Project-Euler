using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Square_Difference
{
    class SumSquare
    {

        public int sumSquare(int sumSquare)
        {
            int sum = 0;

            for(int i =1; i < sumSquare+1; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        public int squareSum(int squareSum)
        {
            int square = 0;
            for(int i = 1; i < squareSum+1; i++)
            {
                square += i;
            }
            return square * square;
        }
    }
}
