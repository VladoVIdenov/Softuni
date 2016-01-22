using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interface;

namespace CompanyHierarchy
{
    public class Sales : ISale
    {

        private string productName;
        private DateTime date;
        private decimal price;

        public Sales(string productName, decimal price, DateTime date)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Date = date;
        }
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value.Year < 1960)
                {
                    throw new ArgumentOutOfRangeException("The date of sale cannot be before 1960");
                }
                this.date = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentNullException("The Product name cannot be null or empty");
                }
                this.productName = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Product Name: {0} , Date of Sale: {1:dd,MM,yyyy} , Price: {2} bgn\n ",
                this.ProductName, this.Date.Date, this.Price);
            return result.ToString();
        }
    }
}
