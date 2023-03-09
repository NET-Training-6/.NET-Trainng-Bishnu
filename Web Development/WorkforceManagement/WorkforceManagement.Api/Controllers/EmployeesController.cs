using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkforceManagement.Web.Data;
using WorkforceManagement.Web.Models;

namespace WorkforceManagement.Api.Controllers;

[Route("api/employees")]
[ApiController]
public class EmployeesController : ControllerBase
{
    WorkforceContext context = new WorkforceContext();

    [HttpGet]
    public IActionResult Get()
    {
        var employees = context.Employees.ToList();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var employee = context.Employees.Find(id);
        if (employee == null)
            return NotFound($"Employee with id {id} does not exist.");

        return Ok(employee);
    }

    [HttpPost]
    public IActionResult Post(Employee employee)
    {
        if (employee == null)
            return BadRequest();

        context.Employees.Add(employee);
        context.SaveChanges();

        return Created($"api/employees/{employee.Id}", null);
    }

    [HttpPut]
    public IActionResult Put(Employee employee)
    {
        context.Employees.Update(employee);
        context.SaveChanges();

        return NoContent();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var employee = context.Employees.Find(id);
        if (employee == null)
            return BadRequest("Employee id you provided does not exist.");

        context.Employees.Remove(employee);
        context.SaveChanges();

        return NoContent();
    }
}

// API, Web API, HTTP API, REST API, HTTP EndPoints
