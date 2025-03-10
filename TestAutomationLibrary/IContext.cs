﻿using TestAutomationLibrary.ContextFeatures;

namespace TestAutomationLibrary
{
    public interface IContext
    {
        IControlFinder ControlFinder { get; }
        IUrlNavigator UrlNavigator { get; }

        void Quit();
    }
}
