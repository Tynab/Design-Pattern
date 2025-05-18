namespace Factory_Method;

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation() => $"Creator: The same creator's code has just worked with {FactoryMethod().Operation()}";
}
