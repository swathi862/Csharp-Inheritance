using System;

namespace garys_garage{

    public class Ram : Vehicle {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank () {
            Console.WriteLine($"Your {this.MainColor} Ram is now refueld to {FuelCapacity} gallons.");
        }

        public void Drive(){
            Console.WriteLine($"The {this.MainColor} growls by you. Rrrrruuummmmbble!");
        }
    }
}