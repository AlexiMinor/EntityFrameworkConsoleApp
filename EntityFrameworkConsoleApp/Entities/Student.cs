namespace EntityFrameworkConsoleApp.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public DateTime BirthDate { get; set; }

    public virtual IEnumerable<StudentCourse> StudentCourses { get; set; }

}