using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01BookProblem
{
    class GoldEditionBook :Book
    {
        private string title;
        private string autorName;
        private double price;

        public GoldEditionBook(string title, string autorName)
            :base(title, autorName)
        {
        }
        public GoldEditionBook(string title, string autorName, double price)
            :base(title, autorName, price)
        {
        }

        public string Title
        {
            get { return base.Title; }
            set
            {
                base.Title = value;
            }
        }
        
        public string AutorName
        {
            get { return base.AutorName; }
            set
            {
                base.Title = value;
            }
        }
        public override double Price
        {
            get
            {
                return this.price = (base.Price + (base.Price * 0.3)); 
            }

            set
            {
                base.Price = value;
            }
        }
       
        public override string ToString()
        {
            return string.Format("title: {0} with auotor {1} and price: {2}", this.Title, this.AutorName, Price);
        }
    }
}
