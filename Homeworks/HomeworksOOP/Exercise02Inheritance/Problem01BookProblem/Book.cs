using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01BookProblem
{
    public class Book
    {
        private string title;
        private string autorName;
        private double normalPrice;

        public Book(string title, string autorName)
        {
            this.Title = title;
            this.AutorName = autorName;
        }
        public Book(string title, string autorName, double price)
        {
            this.Price = price;
        }

        public string Title
        {
            get { return this.Title; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Wrong input data");
                }
                this.Title = value;
            }
        }
        public string AutorName
        {
            get { return this.autorName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Wrong input data");
                }
                this.autorName = value;
            }
        }
        public virtual double Price
        {
            get { return this.normalPrice; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.normalPrice = value;
            }
        }
        public override string ToString()
        {
            return string.Format("title: {0} with auotor {1} and price: {2}", this.Title, this.AutorName,this.Price );
        }

    }
}
