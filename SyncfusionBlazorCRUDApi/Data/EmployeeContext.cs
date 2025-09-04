using Microsoft.EntityFrameworkCore;
using SyncfusionBlazorCRUDApi.Data;

namespace SyncfusionBlazorCRUDApi.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}