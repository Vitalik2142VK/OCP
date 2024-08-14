using System;

namespace OCP
{
    public class PaymentHandler
    {
        public void AcceptPayment(IPaymentSystem paymentSystem)
        {
            paymentSystem.AcceptPayment();
        }

        public void ShowPaymentResult(IPaymentSystem paymentSystem)
        {
            Console.WriteLine($"Вы оплатили с помощью {paymentSystem.SystemId}");

            paymentSystem.CheckPayment();

            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
