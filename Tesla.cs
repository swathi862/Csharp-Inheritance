using System;

namespace garys_garage {

    public class Tesla : Vehicle {  // Electric car
        public double BatteryKWh { get; set; }
        public void ChargeBattery () {
            Console.WriteLine($"Your {MainColor} Tesla is now charged to {BatteryKWh}Kwh.");
         }

        public void Drive(){
            Console.WriteLine($"The {MainColor} Tesla blazes by you. Mmmmmmm!");
        }

        public void Turn(string direction){
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }

        public void Stop(){
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }

}