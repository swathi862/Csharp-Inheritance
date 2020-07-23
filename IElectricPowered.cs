using System;

namespace garys_garage {

    public interface IElectricPowered {

        public double BatteryKWh { get; set; }
        public void ChargeBattery ();

    }
    

}