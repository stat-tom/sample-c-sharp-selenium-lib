namespace TestAutomationLibrary.ByParameters
{
    public class ByName : By
    {
        public string NameValue { get; set; }

        public ByName(string name)
        {
            NameValue = name;
        }

        public override ByType Type => ByType.Name;
    }
}
