using System;


namespace Problem02LapTopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        private double price;
        private Battery battery;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, double price, string manufacturer, Battery battery) : this(model, price)
        {
            this.manufacturer = manufacturer;
            this.battery = battery;
        }
        public Laptop(string model, double price, string manufacturer, string processor, int ram,
            string graphicsCard, int HDD, string screen, Battery battery)
            : this(model, price, manufacturer, battery)
        {

            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model can not be null or empty");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Manufacturer Name can not be null or empty");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Processor parameters can not be bull or empty");
                }
                this.processor = value;
            }
        }
        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Ram size can not be negative");
                }
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Graphic card can not be null or empty");
                }
                this.graphicsCard = value;
            }
        }
        public int Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The size of Hdd can not be negative");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Screen Properties can not be null or empty");
                }
                this.screen = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Price of Laptop can not be negative. Wake up!");
                }
                this.price = value;
            }
        }


        

        public override string ToString()
        {
            string outputString = "Model: " + this.model;
            if (!string.IsNullOrEmpty(this.manufacturer))
            {
                outputString += "\nManufacturer: " + this.manufacturer;
            }
            if (!string.IsNullOrEmpty(this.processor))
            {
                outputString += "\nProcessor: " + this.processor;
            }
            if (this.ram != 0)
            {
                outputString += "\nRam: " + this.ram + "GB";
            }
            if (!string.IsNullOrEmpty(this.graphicsCard))
            {
                outputString += "\nGraphic Card: " + this.graphicsCard;
            }
            if (this.hdd != 0)
            {
                outputString += "\nHDD: " + this.hdd + "GB SSD";
            }
            if (!string.IsNullOrEmpty(this.screen))
            {
                outputString += "\nScreen: " + this.screen;
            }

            outputString += this.battery;

            outputString += "\nPrice: " + this.price + "lv.";

            return outputString;
        }
    }
}
