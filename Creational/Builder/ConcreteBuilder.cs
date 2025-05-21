namespace Builder;

internal sealed record ConcreteBuilder : IBuilder
{
    internal Product _product = new();

    internal ConcreteBuilder() => Reset();

    public void BuildPartA() => _product.Add("PartA1");

    public void BuildPartB() => _product.Add("PartB1");

    public void BuildPartC() => _product.Add("PartC1");

    internal Product GetProduct()
    {
        var result = _product;

        Reset();

        return result;
    }

    private void Reset() => _product = new Product();
}
