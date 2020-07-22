using System;

namespace garys_garage{

    public class Zero : IVehicle, IElectricPowered {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public string MainColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MaximumOccupancy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChargeBattery () { 
            Console.WriteLine($"Your {MainColor} Zero is now charged to {BatteryKWh}Kwh.");
         }

        public void Drive(){
            Console.WriteLine($"The {MainColor} Zero zips by. Yeeeeeow!");
        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero sputters to a stop.");

        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero zooms around a {direction} turn.");

        }
    }

}