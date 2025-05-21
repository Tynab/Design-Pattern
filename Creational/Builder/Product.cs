namespace Builder;

internal sealed record Product
{
    private readonly List<object> _parts = [];

    internal void Add(string part) => _parts.Add(part);

    internal string ListParts()
    {
        var str = string.Empty;

        for (var i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str[..^2];

        return $"Product parts: {str}\n";
    }
}
