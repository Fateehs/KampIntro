using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bu course1'in tipi course ayni string course1 yazmak gibi veya int
            // ve bu bir değişkendir

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.CourseTeacher = "Fatih Selvi";
            course1.ViewsRate = 80;

            Course course2 = new Course();
            course2.CourseName = "JavaScript";
            course2.CourseTeacher = "Fatih Selvi";
            course2.ViewsRate = 77;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.CourseTeacher = "Selin Selvi";
            course3.ViewsRate = 42;

            Course[] courses = new Course[] { course1, course2, course3 };
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.CourseTeacher + " : " + course.ViewsRate);
            }

        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public int ViewsRate { get; set; }
    }
}
