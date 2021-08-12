namespace TestAutomationLibrary.ByParameters
{
    public class ByCssSelector : By
    {
        public string CssSelectorValue { get; set; }

        public ByCssSelector(string className)
        {
            CssSelectorValue = className;
        }

        public override ByType Type => ByType.CssSelector;
    }
}