using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    class StudentSystemContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Students);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Homeworks)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Resources)
                .WithOne(e => e.Course);
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Homeworks)
                .WithOne(e => e.Course);

            modelBuilder.Entity<Homework>()
                 .ToTable("HomeWorkSubmissions");

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server =.; Initial Catalog = StudentSystemDatabase ; Integrated Security =True; Connect Timeout= 30; Encrypt =True;Trust Server Certificate =True;");
        }
       
    
    }
}
