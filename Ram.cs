using System;

namespace garys_garage{

    public class Ram : IVehicle, IGasPowered {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank () {
            Console.WriteLine($"Your {this.MainColor} Ram is now refueld to {FuelCapacity} gallons.");
        }

        public void Drive(){
            Console.WriteLine($"The {this.MainColor} Ram growls by you. Rrrrruuummmmbble!");
        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram rolls around a {direction} turn.");

        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles to a stop.");

        }
    }
}