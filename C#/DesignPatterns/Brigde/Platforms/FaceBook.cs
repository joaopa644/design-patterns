using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brigde.Platforms
{
    class FaceBook : IPlatform
    {
        public FaceBook()
        {
            ConfigureRMTP();
            Console.WriteLine("FaceBook: Transmissão Iniciada.");

        }

        public void AuthToken()
        {
            Console.WriteLine("FaceBook: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("FaceBook: Configurando servidor RMTP.");
        }
    }
}
