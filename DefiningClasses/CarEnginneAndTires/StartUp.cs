using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tires[] tires = new Tires[4]
            {
                new Tires(2000, 2.4),
                new Tires(2000, 2.5),
                new Tires(2000, 2.3),
                new Tires(2000, 2.4)
            };

            var engine = new Engine(500, 1200);

            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

        }
    }
}
