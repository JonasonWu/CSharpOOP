
namespace Assignment3
{
    public class CourseService : ICourseService
    {
        private static CourseService? courseService;

        private Dictionary<int, Course> CourseMap { get; set; }

        private CourseService()
        {
            CourseMap = new();
        }

        public static CourseService GetInstance()
        {
            if (courseService == null)
            {
                courseService = new CourseService();
            }
            return courseService;
        }

        public bool AddCourse(Course course)
        {
            if (CourseMap.ContainsKey(course.Id))
            {
                return false;
            }
            else
            {
                CourseMap.Add(course.Id, course);
                return true;
            }
        }

        public bool RemoveCourse(int id)
        {
            return CourseMap.Remove(id);
        }

        public Course? GetCourse(int id)
        {
            if (!CourseMap.ContainsKey(id))
            {
                return null;
            }
            return CourseMap[id];
        }

        public void PrintEnrolledStudentList(int id)
        {
            if (!CourseMap.ContainsKey(id))
            {
                Console.WriteLine($"Course id of {id} is not found");
                return;
            }
            Course course = CourseMap[id];
            Console.WriteLine($"Course Id: {course.Id}");
            Console.WriteLine($"Course Name: {course.Name}");
            Console.WriteLine($"Students Enrolled: ");
            foreach (Student s in course.StudentList)
            {
                Console.WriteLine($"\t* {s.Id} {s.Name}");
            }
        }
    }
}
