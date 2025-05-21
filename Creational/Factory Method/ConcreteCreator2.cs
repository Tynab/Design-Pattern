namespace Factory_Method;

internal sealed record ConcreteCreator2 : Creator
{
    internal override IProduct FactoryMethod() => new ConcreteProduct2();
}

