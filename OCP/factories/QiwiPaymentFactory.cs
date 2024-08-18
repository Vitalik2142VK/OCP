namespace OCP
{
    public class QiwiPaymentFactory : IPaymentSystemFactory
    {
        public IPaymentSystem Create()
        {
            return new QiwiPayment();
        }
    }
}
