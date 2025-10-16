namespace CollegeManagementSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public static int MaxSubjects = 8;
        public Course()
        {

        }
    }
}
