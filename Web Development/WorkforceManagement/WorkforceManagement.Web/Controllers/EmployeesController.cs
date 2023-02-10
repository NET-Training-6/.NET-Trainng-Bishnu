using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using WorkforceManagement.Web.Data;
using WorkforceManagement.Web.Enums;
using WorkforceManagement.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorkforceManagement.Web.Controllers;
public class EmployeesController : Controller
{
    WorkforceContext db = new WorkforceContext();

    public IActionResult Index()
    {
        List<Employee> employees = db.Employees.ToList();

        return View(employees);
    }
        
    public IActionResult Details(int id) 
    {
        var employee = db.Employees.Find(id);

        return View(employee);
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
