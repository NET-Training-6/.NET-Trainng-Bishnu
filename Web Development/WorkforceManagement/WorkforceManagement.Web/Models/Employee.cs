using WorkforceManagement.Web.Enums;

namespace WorkforceManagement.Web.Models;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public DateTime Dob { get; set; }
    public string Contact { get; set; } = string.Empty;
    public DateTime JoinDate { get; set; }
    public string Department { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
}
