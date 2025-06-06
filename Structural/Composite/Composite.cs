namespace Composite;

internal sealed class Composite : Component
{
    private readonly List<Component> _children = [];

    internal override string Operation()
    {
        var i = 0;
        var result = "Branch(";

        foreach (var child in _children)
        {
            result += child.Operation();

            if (i != _children.Count - 1)
            {
                result += "+";
            }

            i++;
        }

        return result + ")";
    }
    internal override void Add(Component component) => _children.Add(component);

    internal override void Remove(Component component) => _children.Remove(component);
}
