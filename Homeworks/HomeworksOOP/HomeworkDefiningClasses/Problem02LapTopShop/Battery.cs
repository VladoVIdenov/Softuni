using System;

namespace Problem02LapTopShop
{
    public class Battery
    {
        private string batteryModel;
        private double batteryLife;
        

        public Battery(string batteryModel, double batteryLife)
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public string  BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("No battery info");
                }
                this.batteryModel = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The battery life can't be negative ");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            string outputString = string.Empty;
            if (!string.IsNullOrEmpty(this.batteryModel))
            {
                outputString += "\nbattery: " + this.batteryModel;
            }
            if (this.batteryLife != 0)
            {
                outputString += "\nbattery life: " + this.batteryLife;
            }
            return outputString;
        }


    }
}
