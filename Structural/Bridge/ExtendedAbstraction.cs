namespace Bridge;

internal sealed class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
{
    internal override string Operation() => $"ExtendedAbstraction: Extended operation with:\n{_implementation.OperationImplementation()}";
}
