using System.Drawing;

namespace Design_Pattern.Abstract_Factory.Control;

public interface IButton : IControl
{
    /// <summary>
    /// The background color of the button
    /// </summary>
    public Color BackColor { get; set; }
}