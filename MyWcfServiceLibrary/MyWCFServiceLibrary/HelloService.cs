using System.Collections.Generic;

namespace MyWCFServiceLibrary
{
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }

        public string GetSpawnFromProcessFactory(string computername)
        {
            ProcessFactory processFactory = new ProcessFactory(computername);
            string spawnFromProcessFactory = processFactory.StartLocalProcess(processFactory.Computername);
            return spawnFromProcessFactory;
        }

        public string NewServerProcess(string computername, string program, string arguments)
        {
            ProcessFactory processFactory = new ProcessFactory(computername);
            string output = processFactory.StartServerProcess(computername, program, arguments);
            return output;
        }

        public List<string> GetOptions()
        {
            List<string> options = new List<string>();
            string optionA = "public string GetMessage(string name);";
            string optionB = "public string GetSpawnFromProcessFactory(string computername);";
            string optionC = "public List<string> GetOptions();";
            string optionD = "public string NewServerProcess(string computername, string program, string arguments);";
            options.Add(optionA);
            options.Add(optionB);
            options.Add(optionC);
            options.Add(optionD);
            return options;
        }
    }
}
