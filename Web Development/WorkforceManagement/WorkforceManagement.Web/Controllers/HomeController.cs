using Microsoft.AspNetCore.Mvc;

namespace WorkforceManagement.Web.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
