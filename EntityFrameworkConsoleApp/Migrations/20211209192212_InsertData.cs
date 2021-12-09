using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkConsoleApp.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            InsertCourse(migrationBuilder);
        }

        private void InsertCourse(MigrationBuilder migrationBuilder)
        {

            var courseId = Guid.NewGuid().ToString("D");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[Courses]
           ([Id]
           ,[Name]
           ,[Duration])
     VALUES
           ('{courseId}'
           ,'Course from migration'
           ,'15')");


            var studentId = 15;
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[Students]
           ([Name]
           ,[Email]
           ,[Phone]
           ,[BirthDate])
     VALUES
           ('Vasya Pupkin'
           ,'test@email.com'
           ,'123123123'
           ,'1973-07-06 00:00:00.0000000')");

            migrationBuilder.Sql(@$"INSERT INTO [dbo].[StudentCourses]
           ([StudentId]
           ,[CourseId]
           ,[StarDate])
     VALUES
           ('15'
           ,{courseId}
           ,'1973-07-06 00:00:00.0000000')");

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
        private void DeleteCourse(MigrationBuilder migrationBuilder)
        {
            //todo

        }
    }
}
