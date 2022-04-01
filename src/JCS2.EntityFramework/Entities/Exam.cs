namespace JCS2.EntityFramework.Entities
{
    public class Exam
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public int Grade { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
