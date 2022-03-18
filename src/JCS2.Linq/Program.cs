using System;
using System.Linq;

namespace JCS2.Linq
{
    internal class Program
    {
        private static readonly Person[] People = new Person[]
        {
            new Person(){Name="Radek", Surname="Janoštík", Age=30},
            new Person(){Name="Tomáš", Surname="Urbanec", Age=31},
            new Person(){Name="Petr", Surname="Novák", Age=22},
            new Person(){Name="Jan", Surname="Pospíšil", Age=17},
            new Person(){Name="Ondřej", Surname="Vaculík", Age=50},
            new Person(){Name="Martina", Surname="Sáblíková", Age=33},
            new Person(){Name="Martina", Surname="Sáblíková", Age=33},
            new Person(){Name="Klára", Surname="Hustá", Age=18},
            new Person(){Name="Zuzana", Surname="Stará", Age=70},
            new Person(){Name="Alena", Surname="Kolovrátníková", Age=40},
            new Person(){Name="Josef", Surname="Lada", Age=131}
        };

        private static readonly Person[] People1 = new Person[]
        {
            new Person(){Name="Radek", Surname="Janoštík", Age=30},
            new Person(){Name="Tomáš", Surname="Urbanec", Age=31},
            new Person(){Name="Petr", Surname="Novák", Age=22},
            new Person(){Name="Jan", Surname="Pospíšil", Age=17},
            new Person(){Name="Ondřej", Surname="Vaculík", Age=50},
            new Person(){Name="Martina", Surname="Sáblíková", Age=33},
        };

        private static readonly Person[] People2 = new Person[]
        {
            new Person(){Name="Martina", Surname="Sáblíková", Age=33},
            new Person(){Name="Klára", Surname="Hustá", Age=18},
            new Person(){Name="Zuzana", Surname="Stará", Age=70},
            new Person(){Name="Alena", Surname="Kolovrátníková", Age=40},
            new Person(){Name="Josef", Surname="Lada", Age=131}
        };

        private delegate int SomeDelegate(int i);

        static void Main(string[] args)
        {
            SomeDelegate del = (i) => i * 5;
            //Console.WriteLine(del(1));

            Func<int, int> f = (int i) => i * i;
            //Console.WriteLine(f(2));

            Func<int, int> someFunction = GetFunc(10);
            //Console.WriteLine(someFunction.Invoke(2));

            //var a = People.Test().Test();

            //var res = People.Select(p => new { p.Name, p.Surname }).Distinct();
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //var a = People.Distinct().ToList();

            //SetOperations();
        }

        public static void SetOperations()
        {
            var a = People1.Intersect(People2).ToList();
            var b = People1.Union(People2).ToList();
            var c = People1.Except(People2).ToList();
        }

        public static int[] Map(int[] array, Func<int, int> fce)
        {
            int[] res = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                res[i] = fce(array[i]);
            }
            return res;
        }

        public static Func<int, int> GetFunc(int i)
        {
            if (i < 10)
            {
                return (i) => i + 2;
            }

            return (i) => i * i * i * i;
        }
    }
}
