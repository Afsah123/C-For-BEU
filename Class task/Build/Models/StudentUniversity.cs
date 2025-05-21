namespace viewmodeltask.Models
{
    public class StudentUniversity
    {
        public StudentUniversity()
        {
            Subjects = new List<string>();
            Marks = new List<string>();
        }

        public int Id { get; set; }
        public int StudentId { get; set; }
        public List<string> Subjects { get; set; }
        public List<string> Marks { get; set; }

        public StudentPersonal? StudentPersonal { get; set; }
    }
}
