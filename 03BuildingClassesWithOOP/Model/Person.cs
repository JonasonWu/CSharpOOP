
namespace Assignment3
{
    public abstract class Person
    {
        public int Id { get; }

        public string Name { get; set; }

        public DateOnly DOB { get; set; }

        public decimal BaseSalary { get; set; }

        public List<Address> AddressList { get; set; }

        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
            AddressList = new();
        }

        public abstract decimal BonusSalary();

    }
}
