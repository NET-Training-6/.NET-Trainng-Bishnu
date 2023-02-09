using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using WorkforceManagement.Web.Enums;
using WorkforceManagement.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
