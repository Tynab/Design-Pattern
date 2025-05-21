namespace Abstract_Factory;

internal sealed record ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB() => "The result of the product B1.";

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator) => $"The result of the B1 collaborating with the ({collaborator.UsefulFunctionA()})";
}
