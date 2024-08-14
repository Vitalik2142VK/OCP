using System;

namespace OCP
{
    public class PaymentQiwi : IPaymentSystem
    {
        public PaymentSystemId SystemId => PaymentSystemId.QIWI;

        public void AcceptPayment()
        {
            Console.WriteLine("Перевод на страницу QIWI...");
        }

        public void CheckPayment()
        {
            Console.WriteLine("Проверка платежа через QIWI...");
        }
    }
}
