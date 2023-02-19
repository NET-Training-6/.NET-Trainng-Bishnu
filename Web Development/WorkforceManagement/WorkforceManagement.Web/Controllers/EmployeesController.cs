using Microsoft.AspNetCore.Mvc;
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
        List<EmployeeViewModel> employeesViewModels = employees.Select(x => new EmployeeViewModel() 
        {
            Address= x.Address,
            Contact = x.Contact,
            Department= x.Department,
            Designation = x.Designation,
            Dob = x.Dob
        }).ToList();

        return View(employeesViewModels);
    }

    [HttpGet]
    public IActionResult Details(int id) 
    {
        var employee = db.Employees.Find(id);

        return View(employee);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {
        var relativePath = employeeViewModel.ProfileImage?.SaveImage();

        var employee = EmployeeMapper.MapToModel(employeeViewModel);

        employee.ProfileImagePath = relativePath;
        db.Employees.Add(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(EmployeeViewModel employeeViewModel)
    {
        var relativePath = employeeViewModel.ProfileImage?.SaveImage();
        employeeViewModel.ProfileImagePath = relativePath;

        var employee = EmployeeMapper.MapToModel(employeeViewModel);

        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee employee)
    {
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
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
