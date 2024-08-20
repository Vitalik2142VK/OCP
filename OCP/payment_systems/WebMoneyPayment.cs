using System;

namespace OCP
{
    public class WebMoneyPayment : IPaymentSystem
    {
        public WebMoneyPayment()
        {
            SystemId = PaymentSystemId.WebMoney;
        }

        public string SystemId { get; private set; }

        public void AcceptPayment()
        {
            Console.WriteLine("Вызов API WebMoney...");
        }

        public void CheckPayment()
        {
            Console.WriteLine("Проверка платежа через WebMoney...");
        }
    }
}
