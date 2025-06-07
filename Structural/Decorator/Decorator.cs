namespace Decorator;

internal abstract class Decorator(Component component) : Component
{
    protected internal Component _component = component;

    internal override string Operation() => _component is not null ? _component.Operation() : string.Empty;

    internal void SetComponent(Component component) => _component = component;
}
