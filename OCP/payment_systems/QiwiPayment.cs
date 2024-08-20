using System;

namespace OCP
{
    public class QiwiPayment : IPaymentSystem
    {
        public QiwiPayment()
        {
            SystemId = PaymentSystemId.Qiwi;
        }

        public string SystemId { get; private set; }

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
