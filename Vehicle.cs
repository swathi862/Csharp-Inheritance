using System;

namespace garys_garage {

    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive(){
            Console.WriteLine("Vroooooom!");
        }

        public virtual void Turn(string direction){
            Console.WriteLine($"The {MainColor} vehicle carefully turns {direction}.");
        }

        public virtual void Stop(){
            Console.WriteLine($"The {MainColor} vehicle gently rolls to a stop.");
        }
    }
    

}