using System;
using System.IO;
using System.Text.Json;
using JCS2.DataFiles.Data;

namespace JCS2.DataFiles.NetCore
{
    public static class JsonHelper
    {
        public static void SerializePerson()
        {
            var person = new Person { FirstName = "Petr", LastName = "Janis", Age = 24 };

            var content = JsonSerializer.Serialize(person);

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
                person = JsonSerializer.Deserialize<Person>(content);
            }

            Console.WriteLine(person);
        }
    }
}
