namespace Prototype;

internal sealed record Person
{
    internal Person ShallowCopy() => (Person)MemberwiseClone();

    internal Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();

        clone.IdInfo = IdInfo is null ? null : new IdInfo(IdInfo.IdNumber);

        return clone;
    }

    internal int Age;

    internal DateTime BirthDate;

    internal string? Name;

    internal IdInfo? IdInfo;
}
