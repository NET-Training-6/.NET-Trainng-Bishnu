using Microsoft.AspNetCore.Mvc;
using WorkforceManagement.Web.Data;

namespace WorkforceManagement.Web.Controllers;

public class DepartmentsController : Controller
{
    WorkforceContext db = new WorkforceContext();
    public IActionResult Index()
    {
        var departments = db.Departments.ToList();
        return View(departments);
    }

    public IActionResult Add()
    {
        return View();
    }

}
