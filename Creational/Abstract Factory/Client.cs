namespace Abstract_Factory;

internal sealed record Client
{
    internal static void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");

        ClientMethod(new ConcreteFactory1());

        Console.WriteLine("\nClient: Testing the same client code with the second factory type...");

        ClientMethod(new ConcreteFactory2());
    }

    internal static void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}
