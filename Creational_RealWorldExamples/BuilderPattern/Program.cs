using System;
using BuilderPattern.ConcreteBuilders;
using BuilderPattern.Director;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var vehicleCreator = new VehicleCreator(new FordExplorerBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");
            
            vehicleCreator = new VehicleCreator(new LincolnAviatorBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

        }
    }
}
