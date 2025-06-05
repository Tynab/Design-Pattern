using static System.Console;

namespace Factory_Method;

internal sealed record Client
{
    internal static void Main()
    {
        WriteLine("App: Launched with the ConcreteCreator1.");

        ClientCode(new ConcreteCreator1());

        WriteLine("\nApp: Launched with the ConcreteCreator2.");

        ClientCode(new ConcreteCreator2());
    }

    internal static void ClientCode(Creator creator) => WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n{creator.SomeOperation()}");
}
