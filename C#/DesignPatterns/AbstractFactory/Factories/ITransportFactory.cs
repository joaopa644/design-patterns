using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {

        IAircraft CreateTransportAircraft();
        ILandVehicle CreateTransportLandVehicle();

    }
}
