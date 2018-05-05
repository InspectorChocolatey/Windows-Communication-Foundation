using System;
using System.Collections.Generic;
using System.Linq;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting Client...");
            ServiceReference.HelloServiceClient helloserviceclient = new ServiceReference.HelloServiceClient();
            List<string> listOptions = helloserviceclient.GetOptions().ToList();
            Console.WriteLine();
            foreach (string listOption in listOptions)
            {
                Console.WriteLine(listOption);
            }
            Console.WriteLine();
            string example = "A    GetMessage(string name);";
            Console.WriteLine("Example: {0}", example);

            example = "B    GetSpawnFromProcessFactory(string computername);";
            Console.WriteLine("Example: {0}", example);

            example = "C    List<string> GetOptions();";
            Console.WriteLine("Example: {0}", example);

            example = "D    public string NewServerProcess(string computername, string program, string arguments)";
            Console.WriteLine("Example: {0}", example);


            Console.WriteLine("Please enter a command: ");

            bool shouldContinue = true;
            while (shouldContinue)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                if (!String.IsNullOrEmpty(name))
                {
                    if (name == "exit")
                    {
                        shouldContinue = false;                        
                    }
                    else
                    {
                        string response = helloserviceclient.GetMessage(name);
                        Console.WriteLine(response);
                        string computername = Environment.MachineName;
                        string output = helloserviceclient.GetSpawnFromProcessFactory(computername);
                        Console.WriteLine(output);
                        output = helloserviceclient.NewServerProcess(computername, "ipconfig", " /?");
                        Console.WriteLine(output);
                        continue;
                    }
                }
            }
            Console.WriteLine("Press Enter to exit the client");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
