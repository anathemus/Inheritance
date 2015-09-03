using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "i8";
            myCar.Color = "Grey";
            myCar.Year = 2015;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F-450";
            myTruck.Color = "Brown";
            myTruck.Year = 2015;
            myTruck.TowingCapacity = 31200;
            printVehicleDetails(myTruck);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle) 
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());
        }

    }

    abstract class Vehicle 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string FormatMe() 
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }

    class Truck : Vehicle 
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing Capacity (lbs)",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }

    }

}
