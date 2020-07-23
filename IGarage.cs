using System;
using System.Collections.Generic;

namespace garys_garage{

      public interface IGarage<T> // The <T> stands for type. This means that we don't know or care what _type_ of car the garage is going to deal with-- we can decide that when we implement the interface
    {

        // This could be a list of IVehicles, or IElectric, or IGasPowered. The <T> is like a placeholder.
        public List<T> cars {get; set;}

        public int MaxNumOfCarsInGarage {get; set;}

        public void AddCarToGarage(T car);

        public void listCars();
    }
    
}