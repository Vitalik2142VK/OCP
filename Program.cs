using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentSystemIdRepository repository = new PaymentSystemIdRepository();
            OrderForm orderForm = new OrderForm(repository);
            PaymentHandler paymentHandler = new PaymentHandler();
            IPaymentSystemFactory paymentSystemFactory = new PaymentSystemFactory();

            orderForm.ShowForm();

            PaymentSystemId systemId = orderForm.FindPaymentSystemId();
            IPaymentSystem paymentSystem = paymentSystemFactory.Create(systemId);

            paymentHandler.AcceptPayment(paymentSystem);
            paymentHandler.ShowPaymentResult(paymentSystem);

            Console.ReadKey();
        }
    }
}
