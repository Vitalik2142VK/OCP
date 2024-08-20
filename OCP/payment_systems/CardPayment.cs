using System;

namespace OCP
{
    public class CardPayment : IPaymentSystem
    {
        public CardPayment()
        {
            SystemId = PaymentSystemId.Card;
        }

        public string SystemId { get; private set; }

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
