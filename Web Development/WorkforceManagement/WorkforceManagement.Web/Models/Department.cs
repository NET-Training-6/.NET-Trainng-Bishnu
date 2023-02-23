namespace WorkforceManagement.Web.Models;
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime Established { get; set; }
}
