

using System;

namespace AbstractFactory.LandVehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Peguei o Patinete");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Comecei a andar de Patinente");
        }
    }
}
