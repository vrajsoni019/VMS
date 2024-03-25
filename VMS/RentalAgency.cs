// RentalAgency.cs
using System;

public class RentalAgency
{
    // Properties
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
    }

    // Method to add vehicle to fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    // Method to remove vehicle from fleet
    public void RemoveVehicle(int index)
    {
        Fleet[index] = null;
    }

    // Method to rent a vehicle
    public void RentVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            Fleet[index] = null;
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}
