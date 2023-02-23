using Design_Pattern.Abstract_Factory.Service;

namespace Design_Pattern.Abstract_Factory;

public class Application
{
    #region Fields
    private readonly IWidgetFactory _widgetFactory;
    #endregion

    #region Constructors
    public Application(IWidgetFactory widgetFactory) => _widgetFactory = widgetFactory;
    #endregion

    #region Methods
    /// <summary>
    /// Run application.
    /// </summary>
    public void Run()
    {
        // button
        var btn = _widgetFactory.CreateButton();
        btn?.Paint();
        // text box
        var txt = _widgetFactory.CreateTextBox();
        txt?.Paint();
    }
    #endregion
}
