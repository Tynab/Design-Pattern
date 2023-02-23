using Design_Pattern.Abstract_Factory.Control;
using Design_Pattern.Abstract_Factory.Control.Impl;
using static System.Drawing.Color;

namespace Design_Pattern.Abstract_Factory.Service.Impl;

public class MacWidgetFactory : IWidgetFactory
{
    // Implement create button method
    public IButton CreateButton() => new MacButton
    {
        BackColor = White
    };

    // Implement create text box method
    public ITextBox CreateTextBox() => new MacTextBox
    {
        Text = "Mac"
    };
}
