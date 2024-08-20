using System;

namespace OCP
{
    public class PaymentHandler
    {
        private IPaymentSystem _paymentSystem;

        public PaymentHandler(IPaymentSystemFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            _paymentSystem = factory.Create();
        }

        public void AcceptPayment()
        {
            _paymentSystem.AcceptPayment();
        }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Вы оплатили с помощью {_paymentSystem.SystemId}");

            _paymentSystem.CheckPayment();

            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
