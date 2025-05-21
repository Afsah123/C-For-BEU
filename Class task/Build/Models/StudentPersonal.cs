namespace viewmodeltask.Models
{
    public class StudentPersonal
    {
        public StudentPersonal()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Gender = string.Empty;
            Address = string.Empty;
            UniversityDetails = new List<StudentUniversity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public ICollection<StudentUniversity> UniversityDetails { get; set; }
    }
}
