using viewmodeltask.Models;

namespace viewmodeltask.ViewModels
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            PersonalInfo = new StudentPersonal();
            UniversityInfo = new StudentUniversity();
        }

        public StudentPersonal PersonalInfo { get; set; }
        public StudentUniversity UniversityInfo { get; set; }
    }
}
