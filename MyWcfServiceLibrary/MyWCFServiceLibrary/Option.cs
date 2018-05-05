namespace MyWCFServiceLibrary
{
    public class Option
    {
        public string OptionA { get; set; }
        public string OptionB { get; set; }

        public Option()
        {
            
        }

        public void SetOptionA(string optionA)
        {
            this.OptionA = optionA;
        }

        public void SetOptionB(string optionB)
        {
            this.OptionB = optionB;
        }
    }
}
