namespace Builder;

internal sealed record Director
{
    private IBuilder? _builder;

    internal void BuildMinimalViableProduct() => _builder?.BuildPartA();

    internal void BuildFullFeaturedProduct()
    {
        _builder?.BuildPartA();
        _builder?.BuildPartB();
        _builder?.BuildPartC();
    }

    internal IBuilder Builder
    {
        set => _builder = value;
    }
}
