using System.Collections.Generic;

namespace MyWCFServiceLibrary
{
    public class OptionsFactory
    {
        public string OptionA;
        public string OptionB;

        public OptionsFactory()//Option option)
        {
            this.OptionA = "string GetMessage(string name);";
            this.OptionB = "GetSpawnFromProcessFactory(string computername);";
        }
    }
}
