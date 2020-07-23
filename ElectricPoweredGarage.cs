using System;
using System.Collections.Generic;

namespace garys_garage{

        public class ElectricPoweredGarage : IGarage<IElectricPowered>
    {
        public List<IElectricPowered> cars { get; set; }
        public int MaxNumOfCarsInGarage { get; set; }

        public void AddCarToGarage(IElectricPowered car)
        {
            if(cars.Count <= MaxNumOfCarsInGarage){
                cars.Add(car);
            }
            else{
                Console.WriteLine("I'm sorry you've reached the max limit of cars in the garage.");
            }
        }

        public void listCars()
        {
            cars.ForEach(singleCar => Console.WriteLine(singleCar));
        }
    }
}