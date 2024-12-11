using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LojaOnline.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
    }
}