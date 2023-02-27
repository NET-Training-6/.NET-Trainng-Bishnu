using Microsoft.AspNetCore.Mvc;
using WorkforceManagement.Web.Data;
using WorkforceManagement.Web.Models;

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

    [HttpPost]
    public IActionResult Add(Department department)
    {
        if (department is null && !ModelState.IsValid)
            return Problem("To be inserted department object is null");

        db.Departments.Add(department);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
