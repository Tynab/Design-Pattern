using System.Drawing;
using static System.Drawing.Color;

namespace Design_Pattern.Abstract_Factory.Control.Impl;

public class MacButton : IButton
{
    #region Properties
    public Color BackColor { get; set; } = Transparent;
    #endregion

    #region Methods
    // Implement paint method
    public void Paint()
    {
        return;
    }
    #endregion
}
