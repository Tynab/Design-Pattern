using Design_Pattern.Abstract_Factory.Control;
using Design_Pattern.Abstract_Factory.Control.Impl;
using static System.Drawing.Color;

namespace Design_Pattern.Abstract_Factory.Service.Impl;

public class WinWidgetFactory : IWidgetFactory
{
    // Implement create button method
    public IButton CreateButton() => new WinButton
    {
        BackColor = Black
    };

    // Implement create text box method
    public ITextBox CreateTextBox() => new WinTextBox
    {
        Text = "Win"
    };
}
