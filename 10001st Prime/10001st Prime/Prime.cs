using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_Prime
{
    class Prime
    {
        List<int> primes = new List<int>();

        //Populate list with first 6 primes
        public Prime()
        {
            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);
            primes.Add(11);
            primes.Add(13);
        }

        public int getSize()
        {
            return primes.Count;
        }

        public void addPrime(int p)
        {
            primes.Add(p);
        }

        public void writeSize()
        {
            Console.WriteLine(primes.Count);
        }

        public void primeAtIndex(int i)
        {
            Console.WriteLine(primes[i]);
        }
    }
}
