using EntityFrameworkConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkConsoleApp;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-11O0AN1\\SQLSERVER2019;Database=ConsoleAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}