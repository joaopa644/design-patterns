using Brigde.Platforms;
using Brigde.Transmissions;
using System;

namespace Brigde
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLiveAdvanced(new DLive());

            Console.ReadLine();
        }

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Agurade...");

            var live = new Live(platform);

            live.BroadCasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Agurade...");

            var live = new AdvancedLive(platform);

            live.BroadCasting();
            live.Result();
            live.Subtitle();
            live.Comments();
            live.Record();
        }
    }
}
