
namespace Assignment3
{
    public class Budget
    {
        public int Id { get; }

        public decimal BudgetForSchoolYear { get; set; }

        public DateTime SchoolYearStart { get; set; }
        public DateTime SchoolYearEnd { get; set; }

        public Budget(decimal budgetForSchoolYear, DateTime schoolYearStart, DateTime schoolYearEnd)
        {
            BudgetForSchoolYear = budgetForSchoolYear;
            SchoolYearStart = schoolYearStart;
            SchoolYearEnd = schoolYearEnd;
        }
    }
}
