
namespace Assignment3
{
    public class Instructor : Person
    {

        public DateOnly JoinDate { get; set; }

        /// <summary>
        /// The amount of salary bonus gained for every additional year worked.
        /// </summary>
        public int SalaryBonusMultiplier { get; set; }

        public Department BelongingDepartment { get; set; }

        public Instructor(int id, string name, DateOnly joinDate, Department department, int salaryBonusMultiplier = 100) : base(id, name)
        {
            SalaryBonusMultiplier = salaryBonusMultiplier;
            JoinDate = joinDate;
            BelongingDepartment = department;
        }

        public override decimal BonusSalary()
        {
            return SalaryBonusMultiplier * (DateTime.Now.Year - JoinDate.Year);
        }

    }
}
