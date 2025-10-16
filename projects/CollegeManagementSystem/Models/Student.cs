namespace CollegeManagementSystem.Models
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
        public static int MaxEnrolledCourses = 5;
        public static int MaxBooksAllowed = 10;
        public Student()
        {

        }
    }
}
