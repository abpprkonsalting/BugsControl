using Microsoft.EntityFrameworkCore;
using API.Models;
using System.Reflection.Metadata;

namespace API
{
    public partial class BugsControlContext : DbContext
    {
        public BugsControlContext(DbContextOptions<BugsControlContext> options): base(options)
        {
        }
        public virtual DbSet<User> Users => Set<User>();
        public virtual DbSet<Project> Projects => Set<Project>();
        public virtual DbSet<Bug> Bugs => Set<Bug>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { Name = "Usuario1" },
                new User { Name = "Usuario2" },
                new User { Name = "Usuario3" },
                new User { Name = "Usuario4" },
                new User { Name = "Usuario5" }
                );
            modelBuilder.Entity<Project>().HasData(
                new Project { Name = "Projecto1", Description = "projecto1" },
                new Project { Name = "Projecto2", Description = "projecto2" },
                new Project { Name = "Projecto3", Description = "projecto3" },
                new Project { Name = "Projecto4", Description = "projecto4" },
                new Project { Name = "Projecto5", Description = "projecto5" }
                );
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
