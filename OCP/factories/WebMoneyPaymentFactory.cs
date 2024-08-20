namespace OCP
{
    public class WebMoneyPaymentFactory : IPaymentSystemFactory
    {
        public IPaymentSystem Create()
        {
            return new WebMoneyPayment();
        }
    }
}
