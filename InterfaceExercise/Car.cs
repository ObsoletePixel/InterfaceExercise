using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    //Car members
    public bool HasTrunk  { get; set; }
    public string BodyType { get; set; }
    
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
    
    public void OpenTrunk()
    {
        Console.WriteLine(HasTrunk ? $"{GetType().Name} has opened the trunk." : "This vehicle does not have a trunk.");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"This vehicle is a {Color} {Year} {CompanyName} {Model} {BodyType}, made in {Location}.");
    }
}