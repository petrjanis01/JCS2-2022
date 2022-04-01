using System.Data.Entity;
using JCS2.EntityFramework.Entities;

namespace JCS2.EntityFramework
{
    public class SchoolDbContext : DbContext
    {

        public SchoolDbContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School\JCS2\JCS2-2022\src\JCS2.EntityFramework\db.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Exam> Exams { get; set; }
    }
}
