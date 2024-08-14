using System;

namespace OCP
{
    public class PaymentCard : IPaymentSystem
    {
        public PaymentSystemId SystemId => PaymentSystemId.Card;

        public void AcceptPayment()
        {
            Console.WriteLine("Вызов API банка эмитера карты Card...");
        }

        public void CheckPayment()
        {
            Console.WriteLine("Проверка платежа через Card...");
        }
    }
}
