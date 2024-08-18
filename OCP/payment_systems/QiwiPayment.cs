using System;

namespace OCP
{
    public class QiwiPayment : IPaymentSystem
    {
        public string SystemId => PaymentSystemId.Qiwi;

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
