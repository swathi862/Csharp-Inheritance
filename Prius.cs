using System;

namespace garys_garage{

    public class Prius : IVehicle, IGasPowered, IElectricPowered
    {
        public string MainColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MaximumOccupancy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double FuelCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BatteryKWh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your {MainColor} Prius is now charged to {BatteryKWh}Kwh.");

        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Prius cruises by you. Wheee!");

        }

        public void RefuelTank()
        {
            Console.WriteLine($"Your {MainColor} Prius is now refueld to {FuelCapacity} gallons.");

        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Prius rolls to a silent stop.");

        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Prius expertly navigates a {direction} turn.");

        }
    }
}