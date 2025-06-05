using static System.Console;

namespace Abstract_Factory;

internal sealed record Client
{
    internal static void Main()
    {
        WriteLine("Client: Testing client code with the first factory type...");

        ClientMethod(new ConcreteFactory1());

        WriteLine("\nClient: Testing the same client code with the second factory type...");

        ClientMethod(new ConcreteFactory2());
    }

    internal static void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        WriteLine(productB.UsefulFunctionB());
        WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}
