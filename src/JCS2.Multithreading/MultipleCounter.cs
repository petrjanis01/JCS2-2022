using System;
using System.Collections.Generic;
using System.Threading;
using JCS2.Multithreading.Parameters;

namespace JCS2.Multithreading
{
    public class MultipleCounter
    {
        private static readonly Random Random = new Random();

        public static void Run()
        {
            var threads = new List<Thread>();
            var calculationParams = new CalculationParams { Number = 0 };

            for (var i = 0; i < 10; i++)
            {
                var thread = new Thread(Counter);
                threads.Add(thread);
                thread.Start(calculationParams);
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine(calculationParams.Number);
        }

        public static void Counter(object o)
        {
            var param = o as CalculationParams;

            for (var i = 0; i < 100; i++)
            {
                Thread.Sleep(Random.Next(1, 10));
                // TODO lock
                param.Number++;
                Thread.Sleep(Random.Next(1, 10));
            }
        }
    }
}
