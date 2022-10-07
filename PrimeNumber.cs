using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int num = 7;
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Is Prime Number");
            }
            else
            {
                Console.WriteLine("Is Not Prime Number");
            }
        }
    }
}
