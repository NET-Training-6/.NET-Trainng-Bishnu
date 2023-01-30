using Microsoft.AspNetCore.Mvc;

namespace HelloMvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
