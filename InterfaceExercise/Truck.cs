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
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double Horsepower { get; set; }

    //ICompany members
    public string CompanyName { get; set; }
    public string Location { get; set; }
}