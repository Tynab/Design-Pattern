namespace Abstract_Factory;

internal interface IAbstractProductB
{
    internal string UsefulFunctionB();

    internal string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}
