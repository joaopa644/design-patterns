using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();

        }

        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "";

            if(company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if(company == "NineNine")
            {
                transportFactory = new NineNineTransport();
            }else if (company == "Lime")
            {
                transportFactory = new LimeTransport();
            }
            else 
            {
                throw new ArgumentNullException(nameof(ITransportFactory));
            }

            return new Application(transportFactory);
        }
    }
}
