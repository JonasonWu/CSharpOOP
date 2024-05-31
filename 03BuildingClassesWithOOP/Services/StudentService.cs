namespace Assignment3
{
    public class StudentService : PersonService, IStudentService
    {
        private static StudentService? studentService;

        private StudentService()
        {

        }

        public static StudentService GetInstance()
        {
            if (studentService == null)
            {
                studentService = new StudentService();
            }
            return studentService;
        }

        public double CalculateStudentGPA(Student student)
        {
            List<Tuple<Course, Grades>> courses = student.GetEnrolledCoursesWithGrade();
            int courseCount = 0;
            int sumGrades = 0;
            foreach (var c in courses)
            {
                if (c.Item2 == Grades.NONE) continue;
                courseCount++;
                sumGrades += (int)c.Item2;

            }
            if (courseCount == 0) return 0;
            return ((double)sumGrades) / courseCount;

        }
    }
}
