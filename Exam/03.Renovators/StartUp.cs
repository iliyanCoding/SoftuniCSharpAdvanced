using System;
using System.Collections.Generic;

namespace Renovators
{
    public class StartUp
    {
        static void Main()
        {
            Catalog catalog = new Catalog("Quality renovators", 5, "Kitchen");

            // Initialize entity
            Renovator renovator = new Renovator("Gosho", "Painter", 270, 7);

            Console.WriteLine(renovator);

        }
    }
}
