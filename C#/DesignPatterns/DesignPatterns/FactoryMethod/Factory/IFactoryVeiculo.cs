using DesignPatterns.Factory.Product;

namespace DesignPatterns.FactoryMethod.Factory
{
    interface IFactoryVeiculo
    {
        public IVeiculo FactoryMethod(string name);
    }
}
