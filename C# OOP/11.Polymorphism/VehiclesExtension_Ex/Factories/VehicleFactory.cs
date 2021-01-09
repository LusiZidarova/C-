﻿
using VehiclesExtension_Ex.Models;

namespace VehiclesExtension_Ex.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string type,double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirConditioner)
        {
            IVehicle vehicle = null;
            if(type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity , hasAirConditioner);
            }
            else if(type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity, hasAirConditioner);
            }

            return vehicle;
        }
    }
}
