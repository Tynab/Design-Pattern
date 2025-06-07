namespace Decorator;

internal sealed class ConcreteDecoratorA(Component component) : Decorator(component)
{
    internal override string Operation() => $"ConcreteDecoratorA({base.Operation()})";
}
