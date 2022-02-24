using System;
using System.Threading;
using JCS2.Multithreading.Parameters;

namespace JCS2.Multithreading
{
    public static class ResultThreads
    {
        private static readonly Random Random = new Random();

        public static void Run()
        {
            var param = new CalculationParams { Number = 0 };
            var thread1 = new Thread(GenerateNumber);
            thread1.Start(param);
            // Wait for thread to complete
            thread1.Join();
            Console.WriteLine($"Result from first thead: {param.Number}");

            var number = -1;
            var thread2 = new Thread(() => number = GenerateNumber());
            thread2.Start();
            thread2.Join();
            Console.WriteLine($"Result from second thead: {number}");
        }

        private static void GenerateNumber(object o)
        {
            var param = o as CalculationParams;
            Thread.Sleep(1000);
            var number = Random.Next(0, 20);
            Console.WriteLine($"Inside first thead: {number}");
            param.Number = number;
        }

        private static int GenerateNumber()
        {
            var number = Random.Next(0, 20);
            Thread.Sleep(1000);
            Console.WriteLine($"Inside second thead: {number}");
            return number;
        }
    }
}
