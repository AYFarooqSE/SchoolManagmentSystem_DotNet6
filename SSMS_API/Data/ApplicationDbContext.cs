using Microsoft.EntityFrameworkCore;
using SSMS_API.Models;

namespace SSMS_API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<StudentBasicInfo> Tbl_StudentBasicInfo { get; set; }
    }
}
