using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _10001st_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime primes = new Prime();
            int count = 0;
            int primeNumber = 13;

            while(count <= 100)
            {
                for (int i = 2; i <= primeNumber; i++ )
                {
                    if (primeNumber % i == 0)
                    {
                        //Console.WriteLine(primeNumber + " not prime");
                        break;
                    }

                }
                primeNumber += 2;
                primes.addPrime(primeNumber);
                count++;
              //  Console.WriteLine(count);
                
            }

            for(int i =0; i <primes.getSize();i++)
            {
                primes.primeAtIndex(i);
            }

            primes.writeSize();
            Console.Read();

        }
    }
}
