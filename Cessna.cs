using System;

namespace garys_garage{

    public class Cessna : Vehicle {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank () {
            Console.WriteLine($"Your {MainColor} Cessna is now refueld to {FuelCapacity} gallons.");
         }

        public void Drive(){
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zoooooooooom!");
        } 

        public void Stop(){
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}