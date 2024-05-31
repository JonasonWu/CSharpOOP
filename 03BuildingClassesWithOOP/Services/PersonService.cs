
namespace Assignment3
{
    public abstract class PersonService : IPersonService
    {
        protected PersonService() { }

        public int CalculateAge(Person p)
        {
            int unadjustedYear = DateTime.Now.Year - p.DOB.Year;
            //If the person did not celebrate their birthday for the current year yet.
            if (DateTime.Now.Month < p.DOB.Month) return unadjustedYear - 1;
            //If the person already celebrated their birthday for the current year.
            else if (DateTime.Now.Month > p.DOB.Month) return unadjustedYear;
            //If the person's birthday is on the current month, check the day.
            else if (DateTime.Now.Day < p.DOB.Day) return unadjustedYear - 1;
            else return unadjustedYear;

        }

        public decimal CalculateSalary(Person p)
        {
            return p.BaseSalary + p.BonusSalary();
        }

        public List<Address> GetAddresses(Person p)
        {
            return p.AddressList;
        }

        public void PrintDetails(Person p)
        {
            Console.WriteLine($"Person: id {p.Id}, name {p.Name}, age {CalculateAge(p)}, salary {CalculateSalary(p)}.");

        }
    }
}
