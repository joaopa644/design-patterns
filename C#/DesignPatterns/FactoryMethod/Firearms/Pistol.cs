using System;

namespace FactoryMethod.Firearms
{
    class Pistol : IFirearm
    {
        public void Reload()
        {
            Console.WriteLine("Recarregando a pistola.");
        }

        public void Shoot()
        {
            Reload();
            Console.WriteLine("Disparando a pistola.");
        }
    }
}
