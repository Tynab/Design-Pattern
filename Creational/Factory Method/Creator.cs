namespace Factory_Method;

internal abstract record Creator
{
    internal abstract IProduct FactoryMethod();

    internal string SomeOperation() => $"Creator: The same creator's code has just worked with {FactoryMethod().Operation()}";
}
