using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    //SUV members
    public int SeatNumber { get; set; }
    public bool HasSlidingDoors { get; set; }
    
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
    
    public void FillCar(int occupants)
    {
        Console.WriteLine(occupants < SeatNumber ? $"{occupants} of the {SeatNumber} are filled!" : "You are trying to load too many passengers. Please try again.");
    }

    public void DisplayDetails()
    {
        Console.WriteLine(HasSlidingDoors ? $"This vehicle is a {Color} {Year} {CompanyName} {Model} with sliding doors, made in {Location}." : $"This vehicle is a {Color} {Year} {CompanyName} {Model}, made in {Location}.");;
    }
}