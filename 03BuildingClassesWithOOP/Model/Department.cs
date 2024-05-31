
namespace Assignment3
{
    public class Department
    {
        public int Id { get; }

        public string Name { get; set; }

        public Instructor? HeadOfDepartment { get; set; }

        public Budget? SchoolYearBudget { get; set; }

        public List<Course> CoursesOffered { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
            CoursesOffered = new();
        }

    }
}
