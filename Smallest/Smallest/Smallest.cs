using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest
{
    class Smallest
    {

        public bool checkSmallest(int checkSum)
        {
            bool flag = false;
            int check = 0;
            for(int i = 1; i < 20 ; i++)
            {
                flag = false;
                check = i;
                while(flag != true)
                {
                    if (checkSum % i == 0)
                    {
                        flag = true;
                    }
                    else
                        return false;
                }
            }
            return true;

        }
    }
}
