using System;
using System.Collections.Generic;

namespace garys_garage{

        public class GasPoweredGarage : IGarage<IGasPowered>
    {
        public List<IGasPowered> cars { get; set; }
        public int MaxNumOfCarsInGarage { get; set; }

        public void AddCarToGarage(IGasPowered car)
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