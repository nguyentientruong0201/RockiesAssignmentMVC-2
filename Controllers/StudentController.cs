using Microsoft.AspNetCore.Mvc;
using MVCNet6.Models;

namespace MVCNet6.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>{
                new Student {
                                Age = 20,
                                Id = 1,
                                Name = "Thanh"
                },
                new Student {
                                Age = 22,
                                Id = 2,
                                Name = "Thao"
                } };
            return View(students);
        }


        public IActionResult StudentDetails()
        {
            var student = new Student
            {
                Name = "Thanh",
                Age = 20,
                Id = 1,
            };
            return View(student);
        }

        public IActionResult EditStudent()
        {
            var student = new Student
            {
                Name = "Thanh",
                Age = 20,
                Id = 1,
            };
            return View(student);
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return Content($"This is Student : {student.Name}, Age : {student.Age}, Id: {student.Id}") ;
        }
    }
}
