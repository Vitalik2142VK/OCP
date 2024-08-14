using System;

namespace OCP
{
    public class PaymentSystemFactory : IPaymentSystemFactory
    {
        public IPaymentSystem Create(PaymentSystemId systemId)
        {
            switch (systemId)
            {
                case PaymentSystemId.QIWI:
                    return new PaymentQiwi();

                case PaymentSystemId.WebMoney:
                    return new PaymentWebMoney();

                case PaymentSystemId.Card:
                    return new PaymentCard();

                default: throw new InvalidOperationException($"There is no suitable payment system {systemId}");
            }
        }
    }
}
