using TestAutomationLibrary.ContextFeatures;

namespace TestAutomationLibrary
{
    public abstract class Page
    {
        protected readonly IControlFinder controlFinder;

        public Page(IContext context)
        {
            this.controlFinder = context.ControlFinder;
        }
    }
}
