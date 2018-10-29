using System;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsNetcore.Repositories.Database
{
    public class DataBaseContext : IdentityDbContext<User>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<AssignmentRole> AssignmentRole { get; set; }
        public DbSet<Changes> Changes { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Commercial> Commercial { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<HHII> HHII { get; set; }
        public DbSet<JobRole> JobRole { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectComponent> ProjectComponent { get; set; }
        public DbSet<Tech> Tech { get; set; }
        public DbSet<Training> Training { get; set; }
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}
