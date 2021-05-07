using FactoryMethod.Firearms;

namespace FactoryMethod.Factories.TargetShooting
{
    abstract class TargetShooting
    {
        public void StartTargetShooting()
        {
            IFirearm vehicle = CreateFirearm();
            vehicle.Shoot();
        }

        protected abstract IFirearm CreateFirearm();
    }
}
