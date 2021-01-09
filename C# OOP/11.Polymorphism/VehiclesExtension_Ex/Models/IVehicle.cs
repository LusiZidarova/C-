
namespace VehiclesExtension_Ex.Models
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }
        bool HasAirConditioner { get; }
        double AirConditionalFuelConsumption { get; }
        bool Drive(double distance);
        void Refuel(double liters);

        void StartAirConditioner();
        void StopAirConditioner();
    }
}
