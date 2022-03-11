using System;
using System.IO;
using JCS2.DataFiles.Data;
using Newtonsoft.Json;

namespace JCS2.DataFiles.NetFramework
{
    public static class JsonHelper
    {
        public static void SerializePerson()
        {
            var person = new Person { FirstName = "Petr", LastName = "Janis", Age = 24 };

            var content = JsonConvert.SerializeObject(person);

            var outPath = Path.Combine(AppContext.BaseDirectory, "person.json");

            using (var sw = new StreamWriter(outPath))
            {
                sw.Write(content);
            }
        }

        public static void DeserializePerson()
        {
            var personPath = Path.Combine(AppContext.BaseDirectory, "person.json");

            Person person;
            using (var sr = new StreamReader(personPath))
            {
                var content = sr.ReadToEnd();
                person = JsonConvert.DeserializeObject<Person>(content);
            }

            Console.WriteLine(person);
        }
    }
}
