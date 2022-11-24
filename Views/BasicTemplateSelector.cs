using System;
namespace iOSCellReuseBug.Views;

public class BasicTemplateSelector : DataTemplateSelector
{
    public DataTemplate NormalTemplate { get; set; }
    public DataTemplate ScrollableTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return item switch
        {
            ScrollableCellViewModel => ScrollableTemplate,
            _ => NormalTemplate
        };
    }
}

