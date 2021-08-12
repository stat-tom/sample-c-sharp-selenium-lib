using TestAutomationLibrary.ByParameters;

namespace TestAutomationLibrary
{
    public enum ByType
    {
        Name = 1,
        ClassName = 2,
        Id = 3,
        CssSelector = 4
    }

    public abstract class By
    { 

        public abstract ByType Type { get; }

        public static By Name(string name)
        {
            return new ByName(name);
        }

        public static By ClassName(string className)
        {
            return new ByClassName(className);
        }

        public static By Id(string id)
        {
            return new ById(id);
        }

        public static By CssSelector(string cssSelector)
        {
            return new ByCssSelector(cssSelector);
        }
    }
}
