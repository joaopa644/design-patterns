
using System;

namespace FactoryMethod.Firearms
{
    class MachineGun : IFirearm
    {
        public void Reload()
        {
            Console.WriteLine("Recarregando a metralhadora.");
        }

        public void Shoot()
        {
            Reload();
            Console.WriteLine("Disparando a metralhadora.");
        }
    }
}
