namespace CompanyHierarchy.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// Holds collection of Sales for every Sales-Employee.
    /// </summary>
    public interface ISalesEmployee : IEmployee
    {
        List<Sales> Sales { get; set; }
    }
}
