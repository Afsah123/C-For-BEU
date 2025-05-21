using viewmodeltask.Models;
using viewmodeltask.ViewModels;

namespace viewmodeltask.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private List<StudentPersonal> personalData = new List<StudentPersonal>
        {
            new StudentPersonal { Id = 1, Name = "Afsah", Surname = "Zaidi", Gender = "Male", Address = "test address", Age = 23 },
            new StudentPersonal { Id = 2, Name = "Rida", Surname = "Zaidi", Gender = "Women", Address = "test address2", Age = 22 }
        };

        private List<StudentUniversity> universityData = new List<StudentUniversity>
        {
            new StudentUniversity 
            { 
                Id = 1, 
                StudentId = 1, 
                Subjects = new List<string> { "Test1", "Test2" }, 
                Marks = new List<string> { "90", "85" } 
            },
            new StudentUniversity 
            { 
                Id = 2, 
                StudentId = 2, 
                Subjects = new List<string> { "Test2", "Test1" }, 
                Marks = new List<string> { "88", "88" } 
            }
        };

        public List<StudentViewModel> GetAllStudents()
        {
            var students = from personal in personalData
                          join university in universityData
                          on personal.Id equals university.StudentId
                          into universityGroup
                          from university in universityGroup.DefaultIfEmpty()
                          select new StudentViewModel
                          {
                              PersonalInfo = personal,
                              UniversityInfo = university ?? new StudentUniversity 
                              { 
                                  StudentId = personal.Id,
                                  Subjects = new List<string>(),
                                  Marks = new List<string>()
                              }
                          };

            return students.ToList();
        }

        public void AddStudent(StudentViewModel student)
        {
            // Generate new IDs
            int newPersonalId = personalData.Count > 0 ? personalData.Max(p => p.Id) + 1 : 1;
            int newUniversityId = universityData.Count > 0 ? universityData.Max(u => u.Id) + 1 : 1;

            // Set IDs for the new records
            student.PersonalInfo.Id = newPersonalId;
            student.UniversityInfo.Id = newUniversityId;
            student.UniversityInfo.StudentId = newPersonalId;

            // Add to collections
            personalData.Add(student.PersonalInfo);
            universityData.Add(student.UniversityInfo);
        }
    }
}
