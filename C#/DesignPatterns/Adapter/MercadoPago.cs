using System;

namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token Token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void MercadoPagoPayment()
        {
            Token = AuthToken();
            Console.WriteLine("Pagando com o MercadoPago");
        }

        public void MercadoPagoReceivePayment()
        {
            Token = AuthToken();
            Console.WriteLine("Recebendo pagamento com o MercadoPago");
        }
    }
}
