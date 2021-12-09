using System.Diagnostics;
using EntityFrameworkConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();


            using (var context = new SchoolContext())
            {
                //var course1 = new Course()
                //{
                //    Id = Guid.NewGuid(),
                //    Name = $"Test Course #{1}",
                //    Duration = 4F
                //};

                //var ent = await context.Courses.AddAsync(course1);

                //await context.SaveChangesAsync();


                //var list = new List<Student>();
                //for (int i = 0; i < 20; i++)
                //{
                //    var student = new Student()
                //    {
                //        Email = $"test{i}@ema.il",
                //        Name = $"Student {i}",
                //        Phone = (new Random().Next(000000000, 999999999)).ToString(),
                //        BirthDate = new DateTime(new Random().Next(1970, 2000), new Random().Next(1, 12),
                //            new Random().Next(1, 28)),
                //    };
                //    list.Add(student);
                //}

                //await context.Students.AddRangeAsync(list);
                //await context.SaveChangesAsync();

                //var studentIds = await context.Students.Select(student => student.Id).ToListAsync();

                //var studentCoursesList = studentIds.Select(i => new StudentCourse()
                //{
                //    CourseId = new Guid("219D2D34-B683-4D73-A2D7-811006107F5A"),
                //    StudentId = i
                //}).ToList();

                //await context.StudentCourses.AddRangeAsync(studentCoursesList);

                //await context.SaveChangesAsync();



                var concreteCourse = await context.Courses
                    .Include(course => course.StudentCourses)
                    .ThenInclude(course => course.Student)
                    .FirstOrDefaultAsync(course =>
                    course.Id.Equals(new Guid("219D2D34-B683-4D73-A2D7-811006107F5A")));

                var studentNames = concreteCourse.StudentCourses.Select(course => course.Student.Name);


                var studentCourse = context.StudentCourses
                    .Include(course => course.Student)
                    .Include(course => course.Course)
                    .FirstOrDefaultAsync(course => course.Id != 0);


            }


        
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}