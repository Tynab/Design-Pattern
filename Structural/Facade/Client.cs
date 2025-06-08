using static System.Console;

namespace Facade;

internal sealed class Client
{
    internal static void ClientCode(Facade facade) => WriteLine(facade.Operation());
}
