
namespace Assignment3
{
    public class Course
    {
        public int Id { get; }

        public string Name { get; set; }

        public List<Student> StudentList { get; set; }

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
            StudentList = new();
        }

    }
}
