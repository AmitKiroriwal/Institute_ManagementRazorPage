using Institute_Management.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Institute_Management.Data
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
      public  DbSet<ApplicationUser> ApplicationUsers { get; set; }
      public DbSet<Institute> Institutes { get; set; }
      public DbSet<StudentLeads> StudentLeads { get; set; }

    }
}
