using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Peguei a encomenda - UberEats.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Levando a encomenda - UberEats.");
        }
    }
}
