namespace CompanyHierarchy.Interface
{
    /// <summary>
    /// Provides information about Customer's purchases.
    /// </summary>
    public interface ICustomer : IPerson
    {
        decimal PurchaseAmount { get; set; }

        void AddToPurchaseAmount(decimal purchasePrice);
    }
}
