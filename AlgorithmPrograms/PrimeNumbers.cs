using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        public void PrintPrime()
        {
            int flag = 0;
            Console.WriteLine("Prime numbers from 0 to 1000 are:");
            for (int i = 2; i <=1000; i++)
            {
                flag = 0;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag= 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
