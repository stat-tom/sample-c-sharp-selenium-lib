using System.Collections.Generic;

namespace TestAutomationLibrary.Controls
{
    public interface IUnorderedList : IWebControl
    {
        List<IListItem> Items { get; set;}
    }
}
