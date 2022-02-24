using System;
using System.Threading;

namespace JCS2.Multithreading
{
    public class ThreadAborting
    {
        public static void Run()
        {
            var abortableThread = new Thread(() =>
            {
                try
                {
                    CountUp();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Timer aborted");
                    throw;
                }
            });

            abortableThread.Start();

            Thread.Sleep(4000);
            abortableThread.Abort();
        }

        public static void CountUp()
        {
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Abortable timer: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
