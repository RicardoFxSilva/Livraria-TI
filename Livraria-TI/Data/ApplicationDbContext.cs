using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Livraria_TI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}