using System;

namespace OCP
{
    public class WebMoneyPayment : IPaymentSystem
    {
        public string SystemId => PaymentSystemId.WebMoney;

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
