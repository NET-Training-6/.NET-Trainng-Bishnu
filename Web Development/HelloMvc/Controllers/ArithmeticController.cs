using Microsoft.AspNetCore.Mvc;

namespace HelloMvc.Controllers
{
    public class ArithmeticController : Controller
    {
        public IActionResult MTable(int from, int to)
        {
            // Route parameter
            // Query paramter/strings
            var x = (from, to);
            return View(x);
        }
    }
}
