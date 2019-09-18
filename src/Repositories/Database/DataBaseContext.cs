using System;
using System.Linq;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsNetcore.Repositories.Database
{
    public class DataBaseContext : IdentityDbContext<User>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tech> Techs { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<PersonTech> PersonTechs { get; set; }
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>()
                .Property(pc => pc.Status)
                .HasDefaultValue(ProjectStatus.ProductThinking);
            modelBuilder.Entity<Tab>()
                .Property(p => p.Active)
                .HasDefaultValue(false);
            modelBuilder.Entity<Training>()
                .Property(t => t.TrainingStatus)
                .HasDefaultValue(TrainingStatus.NotStarted);
            modelBuilder.Entity<PersonTech>().HasKey(pt => new { pt.PersonId, pt.TechId });
            modelBuilder.Entity<PersonTech>()
                        .HasOne(pt => pt.Person)
                        .WithMany(pt => pt.Techs)
                        .HasForeignKey(pt => pt.PersonId);
            modelBuilder.Entity<PersonTech>()
                        .HasOne(pt => pt.Tech)
                        .WithMany(p => p.Persons)
                        .HasForeignKey(pt => pt.TechId);
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
