namespace Adapter;

internal sealed class Adapter(Adaptee adaptee) : ITarget
{
    private readonly Adaptee _adaptee = adaptee;

    public string GetRequest() => $"This is '{_adaptee.GetSpecificRequest()}'";
}
