using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void checkCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Make},{vehicle.Model},{vehicle.Year}");
            
        }
    }
}
