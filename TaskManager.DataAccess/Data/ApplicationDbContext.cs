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
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Name = "AC", StreetAddress = "Via delle Albizie 22", City = "Roma", State = "Italy", ZIPCode ="BOH"},
                new ApplicationUser { Name = "Nam2", StreetAddress = "V", City = "C", State = "S", ZIPCode = "BOH" }
                );


            base.OnModelCreating(modelBuilder);

            // Aggiungi dati iniziali
            modelBuilder.Entity<Assignment>().HasData(
                new Assignment { Id = 1, TaskName = "Ricreare il sacro romano impero", Description = "Descrizione 1", Starting = DateTime.Now.AddDays(7), Ending = DateTime.Now.AddDays(15), Status = "Completed"},
                new Assignment { Id = 2, TaskName = "Completare il Pokedex", Description = "Descrizione 2", Starting = DateTime.Now.AddDays(14), Ending = DateTime.Now.AddDays(25), Status = "Approved" }
            );
        }
       
    }
}
