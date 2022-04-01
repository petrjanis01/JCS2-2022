using System.Collections.Generic;

namespace JCS2.EntityFramework.Entities
{
    public class Student
    {
        public Student()
        {
            Exams = new List<Exam>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Specialization { get; set; }

        public virtual List<Exam> Exams { get; set; }
    }
}
