using Builder.Products;

namespace Builder.Builders
{
    class PersonBuilder : IBuilderPerson
    {
        public Person SetCompanyData(string chamado)
        {
            return new Person(chamado);
        }

        public Person SetPersonData(string chamado, string cnpj)
        {
            return new Person(chamado, cnpj);
        }
    }
}
