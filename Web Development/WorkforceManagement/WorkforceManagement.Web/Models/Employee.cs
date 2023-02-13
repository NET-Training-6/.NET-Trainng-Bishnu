﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WorkforceManagement.Web.Enums;

namespace WorkforceManagement.Web.Models;
public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter your name")]
    [MinLength(2, ErrorMessage = "At least 2 letters please")]
    public string Name { get; set; } = string.Empty;

    public string? Address { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    
    [DisplayName("Date of birth")]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }
    
    public string Contact { get; set; } = string.Empty;
    
    [DisplayName("Join Date")]
    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }
    
    public string Department { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
}
