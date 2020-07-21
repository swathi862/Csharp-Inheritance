using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero myMotorcycle = new Zero ();
            myMotorcycle.MainColor = "Red";
            myMotorcycle.MaximumOccupancy = "2";
            myMotorcycle.BatteryKWh = 2.0;

            Tesla fancyCar = new Tesla ();
            fancyCar.MainColor = "Silver";
            fancyCar.MaximumOccupancy = "5";
            fancyCar.BatteryKWh = 20.4;

            Cessna personalJet = new Cessna ();
            personalJet.MainColor = "White";
            personalJet.MaximumOccupancy = "15";
            personalJet.FuelCapacity = 80.5;

            Ram superHugeTruck = new Ram();
            superHugeTruck.MainColor = "Blue";
            superHugeTruck.MaximumOccupancy = "5";
            superHugeTruck.FuelCapacity = 40.5;

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(myMotorcycle);
            garage.Add(superHugeTruck);
            garage.Add(fancyCar);
            garage.Add(personalJet);

            personalJet.Drive();
            personalJet.Turn("right");
            personalJet.Stop();

            Console.WriteLine("\n");

            fancyCar.Drive();
            fancyCar.Turn("right");
            fancyCar.Stop();
            
            Console.WriteLine("\n");

            myMotorcycle.Drive();
            myMotorcycle.Turn("right");
            myMotorcycle.Stop();

            Console.WriteLine("\n");

            superHugeTruck.Drive();
            superHugeTruck.Turn("right");
            superHugeTruck.Stop();

            Console.WriteLine();
        }
    }
}
