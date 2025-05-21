namespace Factory_Method;

internal sealed record ConcreteCreator1 : Creator
{
    internal override IProduct FactoryMethod() => new ConcreteProduct1();
}
