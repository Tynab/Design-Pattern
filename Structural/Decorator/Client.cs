using static System.Console;

namespace Decorator;

internal sealed class Client
{
    internal void ClientCode(Component component) => WriteLine($"RESULT: {component.Operation()}");
}
