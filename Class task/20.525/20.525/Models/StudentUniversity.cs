namespace _20._525.Models
{
    public class StudentUniversity
    {
        public int Id { get; set; }
        public int StudentPersonalId { get; set; }
        public StudentPersonal StudentPersonal { get; set; }
        public List<string> Subjects { get; set; }
        public List<decimal> Marks { get; set; }
    }
}
