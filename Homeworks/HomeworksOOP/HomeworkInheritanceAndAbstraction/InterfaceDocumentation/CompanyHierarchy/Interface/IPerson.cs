namespace CompanyHierarchy.Interface
{
    /// <summary>
    /// Provides basic information for all Persons in Company.
    /// </summary>
    public interface IPerson
    {
        string Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string ToString();
    }
}
