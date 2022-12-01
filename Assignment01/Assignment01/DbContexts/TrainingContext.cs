using Assignment01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.DbContexts
{
    public class TrainingContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TrainingContext()
        {
            _connectionString = ConnectionStringReader.ConnectionString;
            _assemblyName = typeof(Program).Assembly.FullName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollments>()
                .HasKey(en => new { en.CourseId, en.StudentId });
            builder.Entity<Enrollments>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.EnrollmentCourses)
                .HasForeignKey(pc => pc.CourseId);
            builder.Entity<Enrollments>()
                .HasOne(pc => pc.Student)
                .WithMany(c => c.EnrollmentStudent)
                .HasForeignKey(pc => pc.StudentId);

            base.OnModelCreating(builder);
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
