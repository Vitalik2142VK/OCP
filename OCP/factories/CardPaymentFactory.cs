namespace OCP
{
    public class CardPaymentFactory : IPaymentSystemFactory
    {
        public IPaymentSystem Create()
        {
            return new CardPayment();
        }
    }
}
