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
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double Horsepower { get; set; }

    //ICompany members
    public string CompanyName { get; set; }
    public string Location { get; set; }
    
}