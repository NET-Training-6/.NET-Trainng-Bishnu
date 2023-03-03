using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkforceManagement.Web.Data;

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
}

// API, Web API, HTTP API, REST API, HTTP EndPoints
