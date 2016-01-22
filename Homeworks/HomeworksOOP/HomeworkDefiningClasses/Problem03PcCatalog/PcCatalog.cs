using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03PcCatalog
{
    class PcCatalog
    {
        static void Main()
        {
            // with many unknowns .....

            Components hdd = new Components("Hard Disc", 150);
            Components motherboard = new Components("Motherboard", 650);
            Components video = new Components("Video Card", 400, "Ati Radeon");
            Components processor = new Components("Intel core", 100, "1 Ghz");
            Components floppy = new Components("Arch", 50);
            Components monitor = new Components("Samsung", 300, "22 inch");
            Components ram = new Components("Ram Corsair", 45.5m, "1 gb");

            List<Components> firstListOfComponents = new List<Components>()
            {
                hdd, motherboard, video, processor, floppy, monitor, ram
            };

            List<Components> secondListOfComponents = new List<Components>()
            {
                hdd, motherboard, video, processor
            };
            List<Components> thirdListOfComponents = new List<Components>()
            {
                video, processor, floppy
            };

            Computer firstComputer = new Computer("Hp", firstListOfComponents);
            Computer secondComputer = new Computer("Hp", secondListOfComponents);
            Computer thirdComputer = new Computer("Hp", thirdListOfComponents);

            List<Computer> computers = new List<Computer>()
            {
                firstComputer, secondComputer, thirdComputer
            };

            List<Computer> sortedList = computers.OrderBy(comp => comp.Price).ToList();

            foreach (var pc in sortedList)
            {
                pc.PrintSelectedConfiguration();
                Console.WriteLine();
            }
        }

    }
}
