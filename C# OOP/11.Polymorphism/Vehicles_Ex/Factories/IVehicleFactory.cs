using System;
using System.Collections.Generic;
using System.Text;
using Vehicles_Ex.Models;

namespace Vehicles_Ex.Factories
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption, bool hasAirConditioner= true);
    }
}
