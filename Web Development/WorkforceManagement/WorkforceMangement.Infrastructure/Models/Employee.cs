using WorkforceManagement.ApplicationCore.Enums;

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
    public string Designation { get; set; } = string.Empty;
    public string ProfileImagePath { get; set; } = string.Empty;

    public int? DepartmentId { get; set; }
    public Department Department { get; set; }
}
