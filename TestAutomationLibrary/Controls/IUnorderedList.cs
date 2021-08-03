using System.Collections.Generic;

namespace TestAutomationLibrary.Controls
{
    public interface IUnorderedList : IControl
    {
        List<IListItem> Items { get; set;}
    }
}
