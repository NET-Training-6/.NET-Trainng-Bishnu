using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkforceManagement.Web.Models;

namespace WorkforceManagement.Web.Data;
public class WorkforceContext: IdentityDbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=WorkforceManagement;Integrated Security=true;");
    }
}
