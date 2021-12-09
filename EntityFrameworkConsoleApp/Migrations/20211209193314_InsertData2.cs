using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkConsoleApp.Migrations
{
    public partial class InsertData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            IsertCourseAndDependentEntities(migrationBuilder);
        }

        private void IsertCourseAndDependentEntities(MigrationBuilder migrationBuilder)
        {
            var courseId = "5467B9BC-6CD4-4F5D-9184-5D32E14159F7";
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
           ,'{courseId}'
           ,'1973-07-06 00:00:00.0000000')");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
