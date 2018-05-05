using System.Collections.Generic;

namespace MyWCFServiceLibrary
{
    public class OptionsFactory
    {
        public string OptionA;
        public string OptionB;

        //public List<Option> listOptions = new List<Option>();
        //MyWCFServiceLibrary.Option myOption = new MyWCFServiceLibrary.Option();
        //MyWCFServiceLibrary.Option option = new Option();
        //MyWCFServiceLibrary.OptionsFactory optionsFactory = new OptionsFactory(option);

        public OptionsFactory()//Option option)
        {
            this.OptionA = "string GetMessage(string name);";
            this.OptionB = "GetSpawnFromProcessFactory(string computername);";
            //option.SetOptionA(thioptionA);
            //option.SetOptionB(optionB);
        }
    }
}
