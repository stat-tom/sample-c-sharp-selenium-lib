namespace TestAutomationLibrary.ByParameters
{
    public class ByClassName : By
    {
        public string ClassNameValue { get; set; }

        public ByClassName(string className)
        {
            ClassNameValue = className;
        }

        public override ByType Type => ByType.ClassName;
    }
}
