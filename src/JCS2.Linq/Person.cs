using System;

namespace JCS2.Linq
{
    public class Person : IEquatable<Person>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public override string ToString() => $"Osoba: {Name} {Surname}, věk: {Age}";

        public bool Equals(Person other)
        {
            if (other is null)
            {
                return false;
            }

            return Name == other.Name && Surname == other.Surname && Age == other.Age;
        }

        public override bool Equals(object obj) => Equals(obj as Person);

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, Age);
        }
    }
}
