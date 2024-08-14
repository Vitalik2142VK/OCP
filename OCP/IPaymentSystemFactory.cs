namespace OCP
{
    public interface IPaymentSystemFactory
    {
        IPaymentSystem Create(PaymentSystemId systemId);        
    }
}
