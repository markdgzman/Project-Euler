using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 100;
            SumSquare a = new SumSquare();

            int sumSquare = a.sumSquare(inputNumber);
            int squareSum = a.squareSum(inputNumber);

            Console.WriteLine(sumSquare);
            Console.WriteLine(squareSum);
            //Difference
            Console.WriteLine(Math.Abs(sumSquare - squareSum));
            Console.Read();
        }
    }
}
