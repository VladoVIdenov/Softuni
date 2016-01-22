namespace CompanyHierarchy.Interface
{
    using System;

    /// <summary>
    /// Provides detailed Project's information. State, Name, Start date and Details.
    /// </summary>
    public interface IProjects
    {
        string State { get; }

        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        void CloseProject();
    }
}
