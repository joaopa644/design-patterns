﻿using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Motorcycle();
        }
    }
}
