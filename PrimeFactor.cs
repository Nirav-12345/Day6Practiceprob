using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRimeFactorOfANumber;

    public class PrimeFactor


    {



        public static void PrimeF()

        {
            double n = Convert.ToInt32(Console.ReadLine());

            int flag;

            if (n == 0)
            {

                Console.WriteLine("Zero is not prime number");
            }

            else if (n == 1)
            {
                Console.WriteLine("One is not prime factor");
            }
            else
            {
                for (float i = 2; i <= n; i++)

                {
                    if (n % i == 0)



                    {

                        flag = 0;
                        for (float j = 2; j <= i / 2; j++)

                        {
                            if (i % j == 0)
                            {

                                flag = 1;

                            }

                        }

                        if (flag == 0)
                        {

                            Console.WriteLine("Prime Factors Of A given Number" + i);
                        }
                    }
                }
            }
        }

    }



