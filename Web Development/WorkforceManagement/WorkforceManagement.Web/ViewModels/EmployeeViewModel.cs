using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using WorkforceManagement.ApplicationCore.Enums;

namespace WorkforceManagement.Web.ViewModels;
public class EmployeeViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter your name"), MinLength(2, ErrorMessage = "At least 2 letters please")]
    public string Name { get; set; } = string.Empty;

    public string? Address { get; set; } = string.Empty;
    public Gender Gender { get; set; }

    [DisplayName("Date of birth"), DataType(DataType.Date)]
    public DateTime Dob { get; set; }

    public string Contact { get; set; } = string.Empty;

    [DisplayName("Join Date"), DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }

    public int Department { get; set; }
    public string DepartmentName { get; set; }

    public string Designation { get; set; } = string.Empty;

    [DisplayName("Your Profile Image")]
    public IFormFile? ProfileImage { get; set; }

    public string ProfileImagePath { get; set; } = string.Empty;
}
