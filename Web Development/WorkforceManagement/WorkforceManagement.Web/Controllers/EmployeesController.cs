using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using WorkforceManagement.Web.Data;
using WorkforceManagement.Web.Helpers;
using WorkforceManagement.Web.Mappers;
using WorkforceManagement.Web.Models;
using WorkforceManagement.Web.ViewModels;

namespace WorkforceManagement.Web.Controllers;
public class EmployeesController : Controller
{
    WorkforceContext db = new WorkforceContext();

    [HttpGet]
    public IActionResult Index()
    {
        List<Employee> employees = db.Employees.ToList();
        List<EmployeeViewModel> employeesViewModels = employees.MapToViewModel();
        return View(employeesViewModels);
    }

    [HttpGet]
    public IActionResult Details(int id) 
    {
        var employee = db.Employees.Find(id);
        var employeeViewModel = employee.MapToViewModel();
        return View(employeeViewModel);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var departments = db.Departments.ToList();
        var depsSelectList = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
        depsSelectList.Add(new SelectListItem { Text = "Select Department...", Selected = true });
        ViewData["Deps"] = depsSelectList;

        return View();
    }

    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {
        var relativePath = employeeViewModel.ProfileImage?.SaveImage();

        var employee = employeeViewModel.MapToModel();

        employee.ProfileImagePath = relativePath;
        db.Employees.Add(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        var employeeViewModel = employee.MapToViewModel();
        return View(employeeViewModel);
    }

    [HttpPost]
    public IActionResult Edit(EmployeeViewModel employeeViewModel)
    {
        var relativePath = employeeViewModel.ProfileImage?.SaveImage();
        employeeViewModel.ProfileImagePath = relativePath;

        var employee = employeeViewModel.MapToModel();

        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        var employeeViewModel = employee.MapToViewModel();
        return View(employeeViewModel);
    }

    [HttpPost]
    public IActionResult Delete(EmployeeViewModel employeeViewModel)
    {
        var employee = employeeViewModel.MapToModel();
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }


    public IActionResult GetData()
    {
        List<Employee> employees = new List<Employee>();

        string connectionString = 
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Workforce_Test;Integrated Security=true;";

        string queryString = "SELECT * from dbo.Employee";
        
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
        
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var employee = new Employee()
                    {
                        Name =  reader.GetString(1),
                        Dob =  reader.GetDateTime(3),
                        //Gender = reader.GetFieldValue<Gender>(2),
                        Contact = reader.GetString(4)
                    };

                    employees.Add(employee);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return View(employees);
    }
}
