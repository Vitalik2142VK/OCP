using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentSystemIdRepository repository = new PaymentSystemIdRepository();
            OrderForm orderForm = new OrderForm(repository);
            IPaymentSystemFactory paymentSystemFactory = new PaymentSystemFactory();

            orderForm.ShowForm();

            PaymentSystemId systemId = orderForm.FindPaymentSystemId();
            IPaymentSystem paymentSystem = paymentSystemFactory.Create(systemId);
            PaymentHandler paymentHandler = new PaymentHandler(paymentSystem);

            paymentHandler.AcceptPayment();
            paymentHandler.ShowPaymentResult();

            Console.ReadKey();
        }
    }
}
