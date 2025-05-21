namespace Factory_Method;

internal sealed record ConcreteProduct1 : IProduct
{
    public string Operation() => "{Result of the ConcreteProduct1}";
}
