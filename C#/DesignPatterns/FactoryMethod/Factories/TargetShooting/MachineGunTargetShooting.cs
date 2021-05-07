using FactoryMethod.Firearms;

namespace FactoryMethod.Factories.TargetShooting
{
    class MachineGunTargetShooting : TargetShooting
    {
        protected override IFirearm CreateFirearm()
        {
            return new MachineGun();
        }
    }
}
