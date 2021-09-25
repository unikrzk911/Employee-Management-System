using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EMSContext: DbContext
    {
        public EMSContext()
        {

        }
        public EMSContext(DbContextOptions<EMSContext> options): base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }

}
