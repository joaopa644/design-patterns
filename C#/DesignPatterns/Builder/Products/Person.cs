using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    public class Person
    {
        public string Name { get; set; }
        public string Idade { get; set; }

        public Person(string chamado)
        {
            Name = chamado;
            Idade = chamado;
        }

        public Person(string chamado, string cnpj) 
        { 

        }
    }
}
