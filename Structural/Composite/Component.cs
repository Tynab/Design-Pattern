namespace Composite;

internal abstract class Component
{
    internal Component() { }

    internal abstract string Operation();

    internal virtual void Add(Component component) => throw new NotImplementedException();

    internal virtual void Remove(Component component) => throw new NotImplementedException();

    internal virtual bool IsComposite() => true;
}
