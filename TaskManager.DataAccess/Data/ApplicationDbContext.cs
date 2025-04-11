using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TaskManager.Models;

namespace TaskManager.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Name = "AC", StreetAddress = "Via delle Albizie 22", City = "Roma", State = "Italy", ZIPCode ="BOH"},
                new ApplicationUser { Name = "Nam2", StreetAddress = "V", City = "C", State = "S", ZIPCode = "BOH" }
                );
        }
    }
}
