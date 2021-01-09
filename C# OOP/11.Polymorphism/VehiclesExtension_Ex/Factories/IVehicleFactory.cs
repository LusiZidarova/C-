
using VehiclesExtension_Ex.Models;

namespace VehiclesExtension_Ex.Factories
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirConditioner= true);
    }
}
