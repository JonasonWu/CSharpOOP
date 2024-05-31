
namespace Assignment3
{
    public interface IPersonService
    {
        int CalculateAge(Person p);

        decimal CalculateSalary(Person p);

        List<Address> GetAddresses(Person p);

        void PrintDetails(Person p);

    }
}
