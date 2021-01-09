using System;
namespace VehiclesExtension_Ex.Models
{
    public abstract class Vehicle : IVehicle
    {
        private const double DefaultFuelQuantity = 0;
        protected Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity, bool hasAirConditioner = true)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.HasAirConditioner = hasAirConditioner;       
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; }

        public double TankCapacity { get;}
        public bool HasAirConditioner { get; protected set; }

        public abstract  double AirConditionalFuelConsumption { get; }

        double IVehicle.TankCapacity => throw new NotImplementedException();

        public bool Drive(double distance)
        {
            double spentFuel = distance * this.FuelConsumption;
            if (this.HasAirConditioner)
            {
                spentFuel += AirConditionalFuelConsumption * distance;
            }

            if(this.FuelQuantity < spentFuel)
            {
                return false;
            }
            this.FuelQuantity -= spentFuel;
            return true;
        }

        public virtual void Refuel(double liters)
        {
            if(liters <= 0)
            {
                throw new Exception("Fuel must be a positive number");

            }
            if((this.TankCapacity - this.FuelQuantity) < liters)
            {
                throw new Exception($"Cannot fit { liters} fuel in the tank");
               
            }
            this.FuelQuantity += liters;
            
        }

        public void StartAirConditioner()
        {
            this.HasAirConditioner = true;
        }

        public void StopAirConditioner()
        {

            this.HasAirConditioner = false;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}\n";
        }
    }
}
