using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCS2.Linq
{
    public static class Extensions
    {
        public static IEnumerable<Person> Test(this IEnumerable<Person> people)
        {
            return people.Where(p => p.Age > 15);
        }
    }
}
