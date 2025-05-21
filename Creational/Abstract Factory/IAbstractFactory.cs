namespace Abstract_Factory;

internal interface IAbstractFactory
{
    internal IAbstractProductA CreateProductA();

    internal IAbstractProductB CreateProductB();
}
