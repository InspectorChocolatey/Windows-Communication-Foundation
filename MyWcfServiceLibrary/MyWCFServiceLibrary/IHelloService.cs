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

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Notes:
 * 
 * Interface : IHelloService
 * 
 * Methods : 
 * 
 *  string GetMessage(string name);
 *  string GetSpawnFromProcessFactory(string computername);
 *  List<string> GetOptions();
 * 
 *~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Questions:
 * 
 *  What are the following things?:
 *  
 *  [ServiceContract]
 * 
 * 
 *  [OperationContract]
 * 
 * 
 *  [DataContract]
 *  
 *  
 *  [DataMember]
 * 
 */
