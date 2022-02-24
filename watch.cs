using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace StopWatch
{
    public class watch
    {
        public static void Watch()

        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            stopwatch.Start();

            for (int i=0; i<=1000; i++)

            {
                Thread.Sleep(10);
            }

            stopwatch.Stop();

            Console.WriteLine("Time Elapsed" + stopwatch.Elapsed);


        }
    }
}
