using System;
using System.Linq;

namespace OCP
{
    public class PaymentSystemIdRepository
    {
        private PaymentSystemId[] _systemIds;
        private string[] _idNames;

        public PaymentSystemIdRepository()
        {
            _systemIds = (PaymentSystemId[])Enum.GetValues(typeof(PaymentSystemId));
            _idNames = _systemIds.Select(t => t.ToString()).ToArray();
        }

        public string[] GetIdNames()
        {
            return _idNames.ToArray();
        }

        public PaymentSystemId FindPaymentSystemId(string paymentSystemRepositId)
        {
            return _systemIds.Where(t => t.ToString().ToLower() == paymentSystemRepositId.ToLower()).First();
        }
    }
}
