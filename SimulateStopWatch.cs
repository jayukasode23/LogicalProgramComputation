using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SimulateStopWatch
    {
        public static void StartTime()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Press Any Key To Start Stopwatch");
            Console.ReadKey();

            //Starting Stopwatch
            stopwatch.Start();

            Console.WriteLine("Press any key to stop Stopwatch");
            Console.ReadKey();

            //Stoping Stopwatch
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            //Declare elapseTime variable to store time 
            string elapseTime = String.Format("{0:00}:{1:00}:{2:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            //Print Elpased time Start To Stop
            Console.WriteLine("Elpased Time in (hour:minutes:seconds:Milliseconds) format is : " + elapseTime);


        }
    }
}
    