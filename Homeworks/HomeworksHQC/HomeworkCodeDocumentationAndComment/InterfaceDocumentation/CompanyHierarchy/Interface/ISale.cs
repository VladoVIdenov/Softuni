namespace CompanyHierarchy.Interface
{
    using System;

    /// <summary>
    /// Provides information about every sale.
    /// </summary>
    public interface ISale 
    {
        string ProductName { get; set; }

        decimal Price { get; set; }

        DateTime Date { get; set; }
    }
}
