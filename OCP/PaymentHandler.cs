using System;

namespace OCP
{
    public class PaymentHandler
    {
        private IPaymentSystem _paymentSystem;

        public PaymentHandler(IPaymentSystem paymentSystem)
        {
            _paymentSystem = paymentSystem ?? throw new ArgumentNullException(nameof(paymentSystem));
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
