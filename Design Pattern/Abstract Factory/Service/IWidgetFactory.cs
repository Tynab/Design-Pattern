using Design_Pattern.Abstract_Factory.Control;

namespace Design_Pattern.Abstract_Factory.Service;

public interface IWidgetFactory
{
    /// <summary>
    /// Creates a button and returns it as an instance of the <see cref="IButton"/> interface.
    /// </summary>
    /// <returns>An instance of the <see cref="IButton"/> interface representing the created button.</returns>
    public IButton CreateButton();

    /// <summary>
    /// Creates a text box and returns it as an instance of the <see cref="ITextBox"/> interface.
    /// </summary>
    /// <returns>An instance of the <see cref="ITextBox"/> interface representing the created text box.</returns>
    public ITextBox CreateTextBox();
}
