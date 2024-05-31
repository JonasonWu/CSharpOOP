
namespace Assignment3
{
    public interface ICourseService
    {
        /// <summary>
        /// Add course into the service for management.
        /// </summary>
        /// <param name="course"></param>
        /// <returns>true if addition is successful. false if the course already exists and cannot be added.</returns>
        bool AddCourse(Course course);

        /// <summary>
        /// Removes course from service management.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public bool RemoveCourse(int courseId);

        /// <summary>
        /// Get the course with specified id.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public Course? GetCourse(int courseId);

        /// <summary>
        /// Print the student list for the course with the specified id.
        /// </summary>
        /// <param name="courseId"></param>
        void PrintEnrolledStudentList(int courseId);
    }
}
