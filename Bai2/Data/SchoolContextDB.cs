using Bai2.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai2.Data
{
    public class SchoolContextDB : DbContext
    {
        public SchoolContextDB (DbContextOptions<SchoolContextDB> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
