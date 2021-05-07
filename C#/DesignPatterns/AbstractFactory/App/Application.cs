using AbstractFactory.AirCrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircraft _airCraft;
        private ILandVehicle _landVehicle;

        public Application(ITransportFactory transportFactory)
        {
            _airCraft = transportFactory.CreateTransportAircraft();
            _landVehicle = transportFactory.CreateTransportLandVehicle();
        }
        

        public void StartRoute()
        {
            _landVehicle.StartRoute();
            _airCraft.StartRoute();
        }
    }
}
