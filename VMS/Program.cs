using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of vehicles
        Vehicle car = new Car("Accord", "Honda", 2022, 50.0, 5, "V8", "Automatic", false);
        Vehicle truck = new Truck("RAM", "Dodge", 2020, 100.0, 2.5, "Pickup", true);
        Vehicle motorcycle = new Motorcycle("CBR", "Honda", 2021, 30.0, 1000, "Gasoline", true);

        // Display vehicle details
        car.DisplayDetails();
        Console.WriteLine();
        truck.DisplayDetails();
        Console.WriteLine();
        motorcycle.DisplayDetails();

        // Demonstrate RentalAgency functionality
        RentalAgency agency = new RentalAgency(10);
        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(motorcycle, 2);

        agency.RentVehicle(0);
        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }
}

