using Brigde.Platforms;
using System;

namespace Brigde.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão");
        }

        public void Comments()
        {
            Console.WriteLine("Comentatios Ativos na Live");
        }

        public void Record()
        {
            Console.WriteLine("A Gravação da Live foi iniciada");
        }
    }
}
