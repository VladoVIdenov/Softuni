using System;
using CompanyHierarchy.Interface;

namespace CompanyHierarchy.Classes
{
    public class Customer : Person, ICustomer
    {

        private decimal purchaseAmount;

        public Customer(string id, string firstName, string lastName)
            :base(id, firstName, lastName)
        {
            this.PurchaseAmount = purchaseAmount;
        }
        public decimal PurchaseAmount
        {
            get { return this.purchaseAmount; }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The Customer's purchase amount cannot be negative");
                }
                this.purchaseAmount = value;
            }
            
        }

        public void AddToPurchaseAmount(decimal purchasePrice)
        {
            this.purchaseAmount += purchasePrice;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Purchases amount : {0} bgn \n", this.PurchaseAmount);
        }
    }
}
