﻿namespace Factory_Method;

internal sealed record Client
{
    internal static void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteCreator1.");

        ClientCode(new ConcreteCreator1());

        Console.WriteLine("\nApp: Launched with the ConcreteCreator2.");

        ClientCode(new ConcreteCreator2());
    }

    internal static void ClientCode(Creator creator) => Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n{creator.SomeOperation()}");
}
