using Brigde.Platforms;
using System;

namespace Brigde.Transmissions
{
    public class Live : ITransmission
    {
        protected IPlatform _platform;

        public Live(IPlatform platform)
        {
            _platform = platform;
        }

        public void BroadCasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("*** ON AIR ***");
        }
    }
}
