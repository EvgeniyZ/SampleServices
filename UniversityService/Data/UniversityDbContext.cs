namespace UniversityService.Data
{
    using Microsoft.EntityFrameworkCore;
    using UniversityService.Data.Entities;

    public sealed class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");

            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().Property(x => x.Name)
                .IsRequired();
        }
    }
}
