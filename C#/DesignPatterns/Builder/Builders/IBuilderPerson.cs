using Builder.Products;

namespace Builder.Builders
{
    interface IBuilderPerson
    {
        Person SetPersonData(string chamado, string cnpj);
        Person SetCompanyData(string chamado);
    }
}
