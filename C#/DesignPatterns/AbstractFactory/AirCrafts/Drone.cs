using System;

namespace AbstractFactory.AirCrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando o vento para o iniciar vôo");
        }

        public void GetCargo()
        {
            Console.WriteLine("O drone pegou a encomenda");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("O drone iniciou a rota de entrega");
        }
    }
}
