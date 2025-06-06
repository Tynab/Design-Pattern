namespace Composite;

internal sealed class Leaf : Component
{
    internal override string Operation() => "Leaf";

    internal override bool IsComposite() => false;
}
