namespace Abstract_Factory;

internal sealed record ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA() => new ConcreteProductA2();

    public IAbstractProductB CreateProductB() => new ConcreteProductB2();
}
