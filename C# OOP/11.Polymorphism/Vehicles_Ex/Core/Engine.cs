using System;
using System.Collections.Generic;
using System.Text;
using Vehicles_Ex.Factories;
using Vehicles_Ex.IO;
using Vehicles_Ex.Models;

namespace Vehicles_Ex.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        public Engine()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
            this.vehicleFactory = new VehicleFactory();
        }
        public void Run()
        {
            string[] carData = this.reader.CustomeReadline().Split();
            IVehicle car = CreateVehicle(carData);

            string[] truckData = this.reader.CustomeReadline().Split();
            IVehicle truck = CreateVehicle(truckData);

            int n = int.Parse(this.reader.CustomeReadline());

            for(int i = 0; i < n; i++)
            {
                string[] args = this.reader.CustomeReadline().Split();

                string command = args[0];
                string vehicleType = args[1];
                double arg = double.Parse(args[2]);
                bool isDrive = false;

                switch (command)
                {
                    case "Drive":
                        {
                            if (vehicleType == nameof(Car))
                            {
                                isDrive = car.Drive(arg);
                            }
                            else if (vehicleType == nameof(Truck))
                            {
                                isDrive = truck.Drive(arg);
                            }
                            if (isDrive)
                            {
                                this.writer.CustomWriteline($"{vehicleType} travelled {arg} km\n");
                            }
                            else
                            {
                                this.writer.CustomWriteline($"{vehicleType} needs refueling\n");
                            }
                        }
                        break;
                    case "Refuel":

                        if (vehicleType == nameof(Car))
                        {
                            car.Refuel(arg);
                        }
                        else if (vehicleType == nameof(Truck))
                        {
                             truck.Refuel(arg);
                        }
                        
                        break;
                }

                
            }
            this.writer.CustomWriteline(car.ToString());
            this.writer.CustomWriteline(truck.ToString());
        }

        private IVehicle CreateVehicle(string[] data)
        {
            string type = data[0];
            double fuelQuantity = double.Parse(data[1]);
            double fuelConsumption = double.Parse(data[2]);

            IVehicle vehicle = this.vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption);
            return vehicle;
        }

        //private void DriveCommand(string vehicleType,IVehicle car,IVehicle truck,double arg)
        
        

    }
}
