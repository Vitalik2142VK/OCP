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

            PaymentSystemId systemId = orderForm.ChooseSystemId();
            PaymentHandler paymentHandler = new PaymentHandler(paymentSystemFactory, systemId);

            paymentHandler.AcceptPayment();
            paymentHandler.ShowPaymentResult();

            Console.ReadKey();
        }
    }
}
