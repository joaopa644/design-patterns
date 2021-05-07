using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    public interface ILandVehicle
    {
        void StartRoute();
        void GetCargo();
    }
}
