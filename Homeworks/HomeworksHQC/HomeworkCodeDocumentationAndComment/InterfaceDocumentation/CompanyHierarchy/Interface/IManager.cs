namespace CompanyHierarchy.Interface
{
    using System.Collections.Generic;
    using CompanyHierarchy.Classes;

    /// <summary>
    /// Holds a collection of Employees subordinate from Manager.
    /// </summary>
    public interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
