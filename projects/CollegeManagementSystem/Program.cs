using CollegeManagementSystem.Models;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student { FirstName = "jon", LastName = "snow", StudentId = 123 };
        Staff staff = new Staff();
        Course computerScience = new Course { CourseId = 22, CourseName = "Computer Science" };

        Console.WriteLine(computerScience.CourseId);
        Console.WriteLine(computerScience.CourseName);
    }
}