namespace CompanyHierarchy.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a collection of Developer's projects
    /// </summary>
    public interface IDeveloper : IEmployee
    {
        List<Projects> ProjectsList { get; set; }
    }
}
