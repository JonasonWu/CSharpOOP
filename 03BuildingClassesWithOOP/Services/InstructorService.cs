namespace Assignment3
{
    public class InstructorService : PersonService, IInstructorService
    {

        private static InstructorService? instructorService;

        private Dictionary<int, Instructor> InstructorMap { get; set; }

        private DepartmentService departmentService;

        private InstructorService()
        {
            InstructorMap = new();
            departmentService = DepartmentService.GetInstance();
        }

        public static InstructorService GetInstance()
        {
            if (instructorService == null)
            {
                instructorService = new InstructorService();
            }
            return instructorService;
        }

        public int CalculateYearsOfExperience(int instructorId)
        {
            if (!InstructorMap.ContainsKey(instructorId)) return -1;
            return DateTime.Now.Year - InstructorMap[instructorId].JoinDate.Year;

        }

        public Department? FindBelongingDepartment(int instructorId)
        {
            if (!InstructorMap.ContainsKey(instructorId)) return null;
            return InstructorMap[instructorId].BelongingDepartment;
        }

        public bool IsHeadOfDepartment(int instructorId)
        {
            if (!InstructorMap.ContainsKey(instructorId)) return false;
            Instructor instructor = InstructorMap[instructorId];
            Department department = instructor.BelongingDepartment;
            if (department.HeadOfDepartment == null) return false;
            return department.HeadOfDepartment.Id == instructor.Id;

        }
    }
}
