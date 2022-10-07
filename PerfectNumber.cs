using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int n, i, sum, mn, mx;
            Console.WriteLine("Input the starting range or number: ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range number:");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perfect numbers within the range:");

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ,", n);

            }
        }
    }
}
