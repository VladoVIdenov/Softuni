namespace CompanyHierarchy.Interface
{
    using CompanyHierarchy.Classes;

    /// <summary>
    /// Holds basic information for all Employees in the Company. Department and Salary
    /// </summary>
    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }

        Department Department { get; }
    }
}
