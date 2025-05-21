namespace Abstract_Factory;

internal sealed record ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA() => new ConcreteProductA1();

    public IAbstractProductB CreateProductB() => new ConcreteProductB1();
}
