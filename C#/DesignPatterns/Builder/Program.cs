using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            VehicleBuilder vehicleBuilder = new VehicleBuilder();
            Director director = new Director(vehicleBuilder);

            director.ConstructSedanCar();

            Vehicle vehicle = vehicleBuilder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {vehicle.VehicleType}");

            director.ConstructTruck();

            Vehicle truck = vehicleBuilder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}");


            Console.ReadLine();
        }
    }
}
