using WorkforceManagement.Web.Models;
using WorkforceManagement.Web.ViewModels;

namespace WorkforceManagement.Web.Mappers
{
    public class EmployeeMapper
    {
        public static Employee MapToModel(EmployeeViewModel employeeViewModel)
        {
            var employee = new Employee
            {
                Id = employeeViewModel.Id,
                Name = employeeViewModel.Name,
                Address = employeeViewModel.Address,
                Contact = employeeViewModel.Contact,
                Department = employeeViewModel.Department,
                Designation = employeeViewModel.Designation,
                Dob = employeeViewModel.Dob,
                Gender = employeeViewModel.Gender,
                JoinDate = employeeViewModel.JoinDate,
                ProfileImagePath = employeeViewModel.ProfileImagePath
            };
            return employee;
        }
    }
}
