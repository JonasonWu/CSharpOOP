
namespace Assignment3
{
    public class Student : Person
    {

        /// <summary>
        /// Outer dictionary maps courseId with Course
        /// </summary>
        private Dictionary<int, Tuple<Course, Grades>> EnrolledCourses { get; set; }

        public Student(int id, string name) : base(id, name)
        {
            EnrolledCourses = new();
        }

        public List<Tuple<Course, Grades>> GetEnrolledCoursesWithGrade()
        {
            return EnrolledCourses.Values.ToList();
        }

        public void AddCourse(Course course)
        {
            EnrolledCourses.Add(course.Id, new Tuple<Course, Grades>(course, Grades.NONE));
        }

        public bool SetCourseGrade(int courseId, Grades grade)
        {
            if (!EnrolledCourses.ContainsKey(courseId)) return false;

            EnrolledCourses.Add(courseId, new Tuple<Course, Grades>(EnrolledCourses[courseId].Item1, grade));
            return true;
        }

        public override decimal BonusSalary()
        {
            return 0;
        }
    }

    public enum Grades
    {
        NONE = -1,
        F = 60,
        D = 65,
        C = 75,
        B = 85,
        A = 95,

    }
}
