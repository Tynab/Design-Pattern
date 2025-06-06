using static System.Console;

namespace Composite;

internal sealed class Client
{
    internal void ClientCode(Component leaf) => WriteLine($"RESULT: {leaf.Operation()}");

    internal void ClientCode(Component component1, Component component2)
    {
        if (component1.IsComposite())
        {
            component1.Add(component2);
        }

        WriteLine($"RESULT: {component1.Operation()}");
    }
}
