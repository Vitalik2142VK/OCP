using System;
using System.Collections.Generic;

namespace OCP
{
    public class PaymentSystemRespository : IPaymentSystemRespository
    {
        private Dictionary<string, IPaymentSystemFactory> _factories;

        public PaymentSystemRespository()
        {
            _factories = CreateFactories();
        }

        public IPaymentSystemFactory FindFactory(string systemId)
        {
            if (systemId == null)
                throw new ArgumentNullException(nameof(systemId));

            if (systemId.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(systemId));

            systemId = FindPaymentSystemIdName(systemId);

            return _factories[systemId];
        }

        public IEnumerable<string> GetSystemFactoryIdNames()
        {
            return _factories.Keys;
        }

        private Dictionary<string, IPaymentSystemFactory> CreateFactories()
        {
            return new Dictionary<string, IPaymentSystemFactory>
            {
                { PaymentSystemId.Qiwi, new QiwiPaymentFactory() },
                { PaymentSystemId.WebMoney, new WebMoneyPaymentFactory() },
                { PaymentSystemId.Card, new CardPaymentFactory() }
            };
        }

        private string FindPaymentSystemIdName(string systemId)
        {
            systemId = systemId.ToLower();

            foreach (string systemName in _factories.Keys)
            {
                if (systemName.ToLower() == systemId)
                    return systemName;
            }

            throw new InvalidOperationException($"The '{systemId}' payment system was not found.");
        }
    }
}
