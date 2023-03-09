using Bai3.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai3.Data
{
        public class DataLabBai3 : DbContext
        {
            public DataLabBai3(DbContextOptions<DataLabBai3> options) : base(options) { }

            public DbSet<Studenter> Studenters { get; set; }
            public DbSet<Enrollmenter> Enrollmenters { get; set; }
            public DbSet<Coursera> Courseras { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Coursera>().ToTable("Coursera");
                modelBuilder.Entity<Enrollmenter>().ToTable("Enrollmenter");
                modelBuilder.Entity<Studenter>().ToTable("Studenter");
            }
        }
}
