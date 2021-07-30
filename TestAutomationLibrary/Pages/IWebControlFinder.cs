﻿using TestAutomationLibrary.Controls;

namespace TestAutomationLibrary.Pages
{
    public interface IWebControlFinder
    {
        ITextInput FindTextInput(string id);

        IButton FindButton(string name);

        IParagraph FindParagraph(string cssSelector);
    }
}
