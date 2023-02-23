namespace Design_Pattern.Abstract_Factory.Control.Impl;

public class MacTextBox : ITextBox
{
    #region Properties
    public string Text { get; set; } = string.Empty;
    #endregion

    #region Methods
    // Implement paint method
    public void Paint()
    {
        return;
    }
    #endregion
}
