﻿// Motorcycle.cs
using System;

public class Motorcycle : Vehicle
{
    // Additional properties for motorcycles
    public double EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice, double engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Override method to display motorcycle details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity} cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
    }
}
