using Microsoft.EntityFrameworkCore;

namespace Crud_Operations_With_EfCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
    }
}
