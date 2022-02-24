using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    public class PerNum
    {

        public static void PerfeN()
        {
            int i, n, sum;

            int mn, mx;
            mn = Convert.ToInt32(Console.ReadLine());
            mx = Convert.ToInt32(Console.ReadLine());

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

                if(sum==n)
                
                    Console.WriteLine(n);
                
            }
        }
    }
}
