using TestAutomationLibrary.ByParameters;

using OpenQA.Selenium;

namespace TestAutomationLibrary.Selenium.ContextFeatures
{
    public class ByFactory
    {
        public ByFactory() { }

        public OpenQA.Selenium.By Create(By by)
        {
            if(by.Type == ByType.Name)
            {
                var name = ((ByName)by).NameValue;
                return OpenQA.Selenium.By.Name(name);
            }
            else if(by.Type == ByType.ClassName)
            {
                var className = ((ByClassName)by).ClassNameValue;
                return OpenQA.Selenium.By.ClassName(className);
            }
            else if (by.Type == ByType.Id)
            {
                var id = ((ById)by).IdValue;
                return OpenQA.Selenium.By.Id(id);
            }
            else
            {
                throw new System.Exception("Missing if condition in ByFactory.");
            }
        }
    }
}
