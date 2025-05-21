using viewmodeltask.ViewModels;

namespace viewmodeltask.Models
{
    public interface IStudentRepository
    {
        List<StudentViewModel> GetAllStudents();
        void AddStudent(StudentViewModel student);
    }
}
