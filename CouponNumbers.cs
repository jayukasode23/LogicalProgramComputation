using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {
        public static void Coupon()
        {
            Console.WriteLine("Enter the distinct Coupon needed:");
            int number = Convert.ToInt32(Console.ReadLine());
            //Declaring i is an variable for coupon array
            int i = 0;
            //Declaring array for distint coupon number
            int[] coupons = new int[number];
            //creating random variable random
            Random random = new Random();

            //Declaring generted variable
            int generated = 0;

            while (i < number)
            {
                int randomNumber = random.Next(number + 1);
                generated++;

                if (coupons.Contains(randomNumber))
                {
                    continue;
                }
                else
                {
                    coupons[i] = randomNumber;
                }
                i++;
            }
            foreach (int Coupon in coupons)
            {
                Console.WriteLine(coupons + " ");
            }
            Console.WriteLine("\n Random numbers needed to generate " + number + "number of coupons are : " + generated);

        }
    }
}
    