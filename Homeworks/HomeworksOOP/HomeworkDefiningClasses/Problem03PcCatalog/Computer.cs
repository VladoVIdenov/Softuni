using System;
using System.Collections.Generic;

namespace Problem03PcCatalog
{
    public class Computer
    {
        private string name;
        private List<Components> components;
        private decimal price;

        public Computer(string name, List<Components> components)
        {
            this.Name = name;
            this.components = components;
            this.Price = calculatedPrice(this.components);
        }
        

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.name = value;
            }
            
        }
        public decimal Price { get; set; }

        private decimal calculatedPrice(List<Components> compts)
        {
            decimal totalPrice = 0;

            foreach (Components component in compts)
            {
                totalPrice += component.Price;
            }
            return totalPrice;
        }
        public void PrintSelectedConfiguration()
        {
            string configuration = "Pc name: " + this.name + "\n";
            foreach (var comp in this.components)
            {
                configuration += comp.ToString() + "\n";
                
            }
            configuration += "Total Price: " + this.Price + "BGN";
            Console.WriteLine(configuration);
        }
    }
}
