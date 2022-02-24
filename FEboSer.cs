using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FebonaciSeries
{
    public class FEboSer
    {
        public static void FSeri()
        {
            int n1 = 0, n2 = 1, n3, i, number;

            number = Convert.ToInt32(Console.ReadLine());

            for (i=2; i<=number; i++)
            {
                n3 = n1 + n2;
                n1 = n2;  n2 = n3;

                Console.WriteLine(n3);

            }

        }
    }
}
