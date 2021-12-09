namespace EntityFrameworkConsoleApp.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public float Duration { get; set; }

    public virtual IEnumerable<StudentCourse> StudentCourses { get; set; }
}