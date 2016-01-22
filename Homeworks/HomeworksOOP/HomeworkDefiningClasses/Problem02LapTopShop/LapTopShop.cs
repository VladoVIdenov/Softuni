using System;

namespace Problem02LapTopShop
{
    class LapTopShop
    {
        static void Main()
        {
            Laptop firstLapTop = new Laptop("Dell Spaceship", 3999.54);
            Laptop secondLapTop = new Laptop("Dell", 958.45, "China", new Battery("Li-Ion", 1.5));
            Laptop thirdLaptop = new Laptop("Dell", 958.45, "China", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)"
                , 8, "Intel HD Graphics 4400", 750, "Samsung 22 inch", new Battery("Li-Ion", 1.5));

            Console.WriteLine(firstLapTop);
            Console.WriteLine();
            Console.WriteLine(secondLapTop);
            Console.WriteLine();
            Console.WriteLine(thirdLaptop);
           
        }
    }
}
