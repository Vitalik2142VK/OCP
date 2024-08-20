using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentSystemRespository paymentSystemRespository = new PaymentSystemRespository();
            OrderForm orderForm = new OrderForm(paymentSystemRespository.GetSystemFactoryIdNames());

            orderForm.ShowForm();

            string systemId = orderForm.ChooseSystemId();
            IPaymentSystemFactory paymentSystemFactory = paymentSystemRespository.FindFactory(systemId);
            PaymentHandler paymentHandler = new PaymentHandler(paymentSystemFactory);

            paymentHandler.AcceptPayment();
            paymentHandler.ShowPaymentResult();

            Console.ReadKey();
        }
    }
}
