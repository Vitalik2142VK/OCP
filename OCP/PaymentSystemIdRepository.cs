using System;
using System.Linq;

namespace OCP
{
    public class PaymentSystemIdRepository
    {
        private PaymentSystemId[] _types;
        private string[] _idNames;

        public PaymentSystemIdRepository()
        {
            _types = (PaymentSystemId[])Enum.GetValues(typeof(PaymentSystemId));
            _idNames = _types.Select(t => t.ToString()).ToArray();
        }

        public string[] GetIdNames()
        {
            return _idNames.ToArray();
        }

        public PaymentSystemId FindPaymentSystemId(string paymentSystemRepositId)
        {
            return _types.Where(t => t.ToString().ToLower() == paymentSystemRepositId.ToLower()).First();
        }
    }
}
