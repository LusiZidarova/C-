using System;
using System.Collections.Generic;
using System.Text;
using Vehicles_Ex.Models;

namespace Vehicles_Ex.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string type,double fuelQuantity, double fuelConsumption, bool hasAirConditioner)
        {
            IVehicle vehicle = null;
            if(type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, hasAirConditioner);
            }
            else if(type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, hasAirConditioner);
            }
            return vehicle;
        }
    }
}
