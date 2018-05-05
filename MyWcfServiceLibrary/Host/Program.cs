using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MyWCFServiceLibrary.HelloService)))
            {
                bool success = true;
                try
                {
                    host.Open();
                    Console.WriteLine("Host started @" + DateTime.Now.ToString());
                }
                catch (AddressAccessDeniedException exception)
                {
                    Console.WriteLine(exception.Message);
                    success = false;
                }
                if (success)
                {
                    //while (true)
                    //{
                    Console.ReadKey();
                    //
                    //}
                }
                else
                {
                    Console.WriteLine("Program is now exiting...");
                    Console.ReadKey();
                }
            }
        }
    }
}
