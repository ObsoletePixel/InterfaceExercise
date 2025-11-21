using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    //Truck members
    public bool IsPickup { get; set; }
    public bool CanOffroad { get; set; }
    
    //IVehicle members
    public int Year { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public bool HasChangedGears { get; set; }

    //ICompany members
    public string CompanyName { get; set; }
    public string Location { get; set; }
    
    public void Drive()
    {
        Console.WriteLine($"{GetType().Name} is now driving.");
    }

    public void Reverse()
    {
        Console.WriteLine(HasChangedGears ? $"{GetType().Name} is now reversing." : "Please change gears first.");
        HasChangedGears = false;
    }

    public void Park()
    {
        Console.WriteLine($"{GetType().Name} has parked.");
    }
    
    public void LoadBed()
    {
        Console.WriteLine(IsPickup ? $"{GetType().Name}'s pickup bed is now loaded" : "This vehicle does not have a pickup bed.");
    }

    public void DisplayDetails()
    {
        Console.WriteLine(CanOffroad ? $"This vehicle is a {Color} {Year} {CompanyName} {Model}, made in {Location}. It can offroad." : $"This vehicle is a {Color} {Year} {CompanyName} {Model}, made in {Location}. It cannot offroad.");
    }
}