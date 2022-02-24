using System;
using System.Threading;

namespace JCS2.Multithreading
{
    public class ParametrizedThreads
    {
        public static void Run()
        {
            var timer2Thread1 = new Thread(CountUp);
            timer2Thread1.Start(new CounterParams { Name = "Timer with object params", Range = 5 });

            var timer2Thread2 = new Thread(() => CountUp("Timer via lambda", 15));
            timer2Thread2.Start();
        }

        private static void CountUp(string timerName, int timerRange)
        {
            Console.WriteLine($"{timerName} is running in thread with ID {Thread.CurrentThread.ManagedThreadId}");

            for (var i = 0; i <= timerRange; i++)
            {
                Console.WriteLine($"{timerName}: {i}");
                Thread.Sleep(1000);
            }
        }

        private static void CountUp(object o)
        {
            var counterParams = o as CounterParams;

            Console.WriteLine($"{counterParams.Name} is running in thread with ID {Thread.CurrentThread.ManagedThreadId}");

            for (var i = 0; i <= counterParams.Range; i++)
            {
                Console.WriteLine($"{counterParams.Name}: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
