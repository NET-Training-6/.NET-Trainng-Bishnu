using HelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // List of students
            Student student1 = new()
            {
                Name = "Ram",
                Address = "Ktm",
                Email = "ram@gmail.com",
                Dob = new DateTime(1998, 8, 12)
            };

            Student student2 = new()
            {
                Name = "Shyam Basnet",
                Address = "Bhaktapur",
                Email = "shyam@gmail.com",
                Gender = Sex.Male,
                Dob = new DateTime(1995, 3, 24)
            };

            List<Student> students = new() { student1, student2 };

            return View(students);
        }

        public IActionResult Test()
        {
            int[] numbers = { 2, 3, 4, 5, 6, 12, 78, 98, 12, 34, 54, 32, 21 };
            return View(numbers);
        }
    }
    
}
