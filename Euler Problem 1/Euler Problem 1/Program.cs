﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are the multiples of 3 and 5: ");


            for (int i = 0; i <= 1000; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                Console.Write(i + " ");
            }

                Console.ReadLine();
        }
    }
}
