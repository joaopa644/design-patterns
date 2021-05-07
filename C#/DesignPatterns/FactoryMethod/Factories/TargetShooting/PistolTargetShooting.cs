using FactoryMethod.Firearms;

namespace FactoryMethod.Factories.TargetShooting
{
    class PistolTargetShooting : TargetShooting
    {
        protected override IFirearm CreateFirearm()
        {
            return new Pistol();
        }
    }
}
