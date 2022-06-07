using System;
using System.Collections.Generic;

namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    string[] carArgs = input.Split(", ");
                    string direction = carArgs[0];
                    string carNumber = carArgs[1];

                    if (direction == "IN")
                    {
                        cars.Add(carNumber);
                    }
                    else
                    {
                        cars.Remove(carNumber);
                    }
                }
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
