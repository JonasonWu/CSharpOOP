
namespace Assignment3
{
    public interface IDepartmentService
    {
        /// <summary>
        /// Add department to be managed by service.
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        bool AddDepartment(Department department);

        /// <summary>
        /// Get department specified by id.
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        Department? GetDepartment(int departmentId);

        /// <summary>
        /// Get head instructor of department specified by id.
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        Instructor? GetDepartmentHead(int departmentId);

        /// <summary>
        /// Get budget for school year of department specified by id.
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        Budget? GetDepartmentBudget(int departmentId);

        /// <summary>
        /// Get list of courses offered by department specified by id.
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        List<Course>? GetDepartmentCourses(int departmentId);

        /// <summary>
        /// Print details of the department.
        /// </summary>
        /// <param name="departmentId"></param>
        void PrintDepartmentDetails(int departmentId);

    }
}
