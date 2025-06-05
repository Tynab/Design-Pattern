namespace Bridge;

internal class Abstraction(IImplementation implementation)
{
    protected internal IImplementation _implementation = implementation;

    internal virtual string Operation() => $"Abstract: Base operation with:\n{_implementation.OperationImplementation()}";
}
