namespace JCS2.DataFiles.Data
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string FullName => $"{FirstName} {LastName}";

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FullName}, Age: {Age}";
        }
    }
}