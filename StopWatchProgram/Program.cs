using System.Diagnostics;

namespace StopWatchProgram
{
    public class StopWatch
    {
        public static void DisplayTime()
        {
            Stopwatch stopwatch = new Stopwatch();

            //used stopwatch class to get elapsed time
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            StopWatch.DisplayTime();
        }
    }
}