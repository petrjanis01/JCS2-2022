using System;
using System.Threading;
using JCS2.Multithreading;
using JCS2.Multithreading.Parameters;

namespace JSC2.Multithreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            Console.WriteLine(mainThread.ManagedThreadId);

            //var timer1Thread = new Thread(CountDown);
            //timer1Thread.Start();

            //ParametrizedThreads.Run();

            //ResultThreads.Run();

            //ThreadAborting.Run();

            MultipleCounter.Run();

            Console.WriteLine($"Main thread with id: {mainThread.ManagedThreadId} completed.");

            Console.ReadKey();
        }

        public static void CountDown()
        {
            Console.WriteLine($"Timer1 is running in thread with ID {Thread.CurrentThread.ManagedThreadId}");

            for (var i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer1: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}