using System.ServiceModel;
using System.Collections.Generic;

namespace MyWCFServiceLibrary
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        string GetSpawnFromProcessFactory(string computername);

        [OperationContract]
        string NewServerProcess(string computername, string program, string arguments);

        [OperationContract]
        List<string> GetOptions();
    }
}
