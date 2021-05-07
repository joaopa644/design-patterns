using System;

namespace DesignPatterns.Factory.Product
{
    class Carro : IVeiculo
    {
        public string Name { get; private set; }

        public Carro(string name)
        {
            Name = name;
        }

        public void Andar()
        {
            Console.WriteLine($"{Name} esta andando");
        }

        public void Parar()
        {
            Console.WriteLine($"{Name} parou");
        }
    }
}
