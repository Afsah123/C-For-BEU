using Microsoft.AspNetCore.Mvc;
using viewmodeltask.Models;
using viewmodeltask.Repositories;
using viewmodeltask.ViewModels;

namespace viewmodeltask.Controllers
{
    public class StudentController : Controller
    {
        private static readonly IStudentRepository _studentRepository = new StudentRepository();

        public StudentController()
        {
        }

        public IActionResult Index()
        {
            List<StudentViewModel> students = _studentRepository.GetAllStudents();
            return View(students);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
