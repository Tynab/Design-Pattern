namespace Abstract_Factory;

internal sealed record ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB() => "The result of the product B2.";

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator) => $"The result of the B2 collaborating with the ({collaborator.UsefulFunctionA()})";
}
