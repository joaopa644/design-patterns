﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AirCrafts
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento - Helicoptero.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok - Helicoptero.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem - Helicoptero.");
        }
    }
}
