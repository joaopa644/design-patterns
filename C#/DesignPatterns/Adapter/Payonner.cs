using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Payonner : IPayonnerPayment
    {

        private Token Token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            Token = AuthToken();
            Console.WriteLine("Recebendo pagamento como Payonner");
        }

        public void SendPayment()
        {
            Token = AuthToken();
            Console.WriteLine("Pagando pagamento como Payonner");
        }
    }
}
