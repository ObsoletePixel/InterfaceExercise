using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var car1 = new Car();
            car1.BodyType = "Sedan";
            car1.HasTrunk = true;
            car1.Year = 2018;
            car1.Model = "330i";
            car1.Color = "White";
            car1.CompanyName = "BMW";
            car1.Location = "Germany";
            
            var truck1 = new Truck();
            truck1.IsPickup = true;
            truck1.CanOffroad = false;
            truck1.Year = 1997;
            truck1.Model = "F150";
            truck1.Color = "Red";
            truck1.CompanyName = "Ford";
            truck1.Location = "The USA";
            
            var suv1 = new SUV();
            suv1.SeatNumber = 7;
            suv1.HasSlidingDoors = true;
            suv1.Year = 2021;
            suv1.Model = "Pilot";
            suv1.Color = "Black";
            suv1.CompanyName = "Honda";
            suv1.Location = "Japan";

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of the method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            car1.DisplayDetails();
            truck1.DisplayDetails();
            suv1.DisplayDetails();
        }
    }
}
