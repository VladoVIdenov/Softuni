using System;

namespace Problem03PcCatalog
{
    public class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Components(string name, decimal price, string details)
            : this(name, price)
        {
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null or empty");
                }
                this.name = value;
            }
        }
        public string Details { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Price cannot be negative");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return this.name + ", " + (this.details + " " ?? "") + this.price + " BGN";
         }

    }
}
