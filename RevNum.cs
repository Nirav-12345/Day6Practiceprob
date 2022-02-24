using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnumber
{
    public class RevNum
    {


        public static void RNum()

        {
            int n, reverse = 0, rem;

            n = Convert.ToInt32(Console.ReadLine());

            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;

                n /= 10;

                Console.WriteLine(reverse);
            }
        }
    }
}
