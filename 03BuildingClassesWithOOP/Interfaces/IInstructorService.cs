namespace Assignment3
{
    public interface IInstructorService : IPersonService
    {

        Department? FindBelongingDepartment(int instructorId);

        bool IsHeadOfDepartment(int instructorId);

        int CalculateYearsOfExperience(int instructorId);

    }
}
