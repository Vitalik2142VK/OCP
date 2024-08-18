namespace OCP
{
    public interface IPaymentSystem
    {
        string SystemId { get; }

        void AcceptPayment();

        void CheckPayment();
    }
}
