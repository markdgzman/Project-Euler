using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest
{
    class Program
    {
        static void Main(string[] args)
        {

            Smallest a = new Smallest();

            int checkSum = 20;
            bool flag = false;

            while(flag == false)
            {
            
                flag = a.checkSmallest(checkSum);
                checkSum += 20;
            }
            //232792560
            Console.WriteLine(checkSum -20);
            Console.Read();
            
        }
    }
}
