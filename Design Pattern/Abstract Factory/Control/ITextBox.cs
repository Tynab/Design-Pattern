namespace Design_Pattern.Abstract_Factory.Control;

public interface ITextBox : IControl
{
    /// <summary>
    /// The text associated with the control.
    /// </summary>
    public string Text { get; set; }
}
