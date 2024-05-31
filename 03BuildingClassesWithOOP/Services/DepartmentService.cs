
namespace Assignment3
{
    public class DepartmentService : IDepartmentService
    {

        public static DepartmentService? departmentService;

        private Dictionary<int, Department> departmentMap;

        private DepartmentService()
        {
            departmentMap = new();
        }
        public static DepartmentService GetInstance()
        {
            if (departmentService == null)
            {
                departmentService = new DepartmentService();
            }
            return departmentService;
        }

        public bool AddDepartment(Department department)
        {
            if (departmentMap.ContainsKey(department.Id)) return false;

            departmentMap.Add(department.Id, department);
            return true;
        }

        public Department? GetDepartment(int id)
        {
            if (!departmentMap.ContainsKey(id)) return null;

            return departmentMap[id];
        }

        public Budget? GetDepartmentBudget(int id)
        {
            Department? department = GetDepartment(id);
            if (department == null) return null;
            return department.SchoolYearBudget;
        }

        public List<Course>? GetDepartmentCourses(int id)
        {
            Department? department = GetDepartment(id);
            if (department == null) return null;
            return department.CoursesOffered;
        }

        public Instructor? GetDepartmentHead(int id)
        {
            Department? department = GetDepartment(id);
            if (department == null) return null;
            return department.HeadOfDepartment;
        }

        public void PrintDepartmentDetails(int id)
        {
            Console.WriteLine($"Department Details Overview:");
            foreach (Department d in departmentMap.Values)
            {
                Console.WriteLine($"Id: {d.Id}, Department {d.Name}, Department Head: {d.HeadOfDepartment.Name}");
            }

        }
    }
}
