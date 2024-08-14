namespace OCP
{
    public interface IPaymentSystem
    {
        PaymentSystemId SystemId { get; }

        void AcceptPayment();

        void CheckPayment();
    }
}
