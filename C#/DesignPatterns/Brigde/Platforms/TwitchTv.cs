﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brigde.Platforms
{
    class TwitchTv : IPlatform
    {
        public TwitchTv()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTv: Transmissão Iniciada.");

        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTv: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTv: Configurando servidor RMTP.");
        }
    }
}
