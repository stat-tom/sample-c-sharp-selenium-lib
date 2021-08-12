namespace TestAutomationLibrary.ByParameters
{
    public class ById : By
    {
        public string IdValue { get; set; }

        public ById(string id)
        {
            IdValue = id;
        }

        public override ByType Type => ByType.Id;
    }
}
