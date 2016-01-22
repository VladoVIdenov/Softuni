using System;
using GalacticGPS;
using System.Collections;
using System.Collections.Generic;

public enum Planet
{
    Mercury,
    Venus,
    Earth,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune,
}
class Program
{
    static void Main()
    {
        List<Location> planets = new List<Location>()
        {
            new Location(60.998849, -70.635896, Planet.Mars),
            new Location(18.037986, 28.870097, Planet.Earth),
            new Location(-70.889946, 88.998877, Planet.Uranus),
        };

        foreach (var planet in planets)
        {
            Console.WriteLine(planet);
        }
    }
}

