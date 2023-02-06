using Microsoft.AspNetCore.Mvc;
using WorkforceManagement.Web.Enums;
using WorkforceManagement.Web.Models;

namespace WorkforceManagement.Web.Controllers;
public class EmployeesController : Controller
{
    public IActionResult Index()
    {
        Employee employee1 = new Employee
        {
            Name = "Bishnu Rawal",
            Gender = Gender.Male,
            Contact = "7983798789",
            Address = "Kathmandu",
            Dob = new DateTime(1988, 12, 23),
            Department = "Research & Development",
            Designation = "Software Architect"
        };

        Employee employee2 = new Employee
        {
            Name = "Bishnu Rawal",
            Gender = Gender.Male,
            Contact = "7983798789",
            Address = "Kathmandu",
            Dob = new DateTime(1988, 12, 23),
            Department = "Research & Development",
            Designation = "Software Architect"
        };

        List<Employee> employees = new() { employee1, employee2 };

        return View(employees);
    }
}
