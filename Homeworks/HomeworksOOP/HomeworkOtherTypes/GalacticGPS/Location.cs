using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet):this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < - 90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Invalid Latitude coordinates");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Invalid Longitude coordinates");
                }
                this.longitude = value;
            }
        }
        public Planet Planet { get; }

        public override string ToString()
        {
            return string.Format("Latitude: {0}\nLongitude: {1}\nPlanet: {2}\n", this.Latitude, this.Longitude, this.planet);
        }
    }
}
