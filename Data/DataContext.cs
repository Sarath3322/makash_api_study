using Microsoft.EntityFrameworkCore;

namespace makash_api_study.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        //public DbSet<Employee> Employees { get; set; }
    }
}
