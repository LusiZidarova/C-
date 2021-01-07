using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Ex.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, bool hasAirConditioner = true)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.HasAirConditioner = hasAirConditioner;       
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; }

        public bool HasAirConditioner { get; }

        public abstract  double AirConditionalFuelConsumption { get; }

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
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}\n";
        }
    }
}
