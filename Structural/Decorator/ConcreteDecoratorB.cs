namespace Decorator;

internal sealed class ConcreteDecoratorB(Component component) : Decorator(component)
{
    internal override string Operation() => $"ConcreteDecoratorB({base.Operation()})";
}
