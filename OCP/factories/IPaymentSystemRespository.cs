using System.Collections.Generic;

namespace OCP
{
    public interface IPaymentSystemRespository
    {
        IPaymentSystemFactory FindFactory(string systemId);

        IEnumerable<string> GetSystemFactoryIdNames();
    }
}
