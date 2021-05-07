using DesignPatterns.Factory.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.Factory
{
    class FactoryCarro : IFactoryVeiculo
    {
        public IVeiculo FactoryMethod(string name)
        {
            return new Carro(name);
        }
    }
}
