using System;

namespace garys_garage{

    public class Zero : Vehicle {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery () { 
            Console.WriteLine($"Your {MainColor} Zero is now charged to {BatteryKWh}Kwh.");
         }

        public void Drive(){
            Console.WriteLine($"The {MainColor} Zero zips by. Yeeeeeow!");
        }    
    }

}