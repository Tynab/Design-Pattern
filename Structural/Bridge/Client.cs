using static System.Console;

namespace Bridge;

internal sealed class Client
{
    internal void ClientCode(Abstraction abstraction) => Write(abstraction.Operation());
}
