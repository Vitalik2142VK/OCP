using System;

namespace OCP
{
    public class CardPayment : IPaymentSystem
    {
        public string SystemId => PaymentSystemId.Card;

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
