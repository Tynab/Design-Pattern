namespace Singleton;

internal sealed record Singleton
{
    private static Singleton? _instance;

    private Singleton() { }

    internal static Singleton GetInstance()
    {
        _instance ??= new Singleton();

        return _instance;
    }
}
