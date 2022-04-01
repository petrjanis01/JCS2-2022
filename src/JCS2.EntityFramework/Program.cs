using System;
using System.Linq;
using JCS2.EntityFramework.Entities;

namespace JCS2.EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddStudent();

            using var context = new SchoolDbContext();

            var query = context.Students.Where(s => s.FirstName.Contains("P"));

            query = query.Where(s => s.LastName.Contains("J"));

            var students = query.ToList();
            Console.WriteLine($@"{students[0].FirstName} {students[0].LastName}");

            var exam = students[0].Exams.First(e => e.Grade == 2);
        }

        private static void AddStudent()
        {
            using var context = new SchoolDbContext();

            context.Students.Add(new Student { Id = 1, FirstName = "Petr", LastName = "Janis", Specialization = "IT" });
            context.Exams.Add(new Exam { Id = 1, StudentId = 1, Subject = "ABC", Grade = 2 });

            context.SaveChanges();
        }
    }
}
