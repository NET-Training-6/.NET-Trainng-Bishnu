using System.ComponentModel.DataAnnotations;

namespace WorkforceManagement.Web.Models;
public class Department
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;

    [DataType(DataType.MultilineText)]
    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime Established { get; set; }

    public List<Employee> Employees { get; set; }
}
