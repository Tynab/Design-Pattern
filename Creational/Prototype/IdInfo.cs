namespace Prototype;

internal sealed record IdInfo
{
    internal IdInfo(int idNumber) => IdNumber = idNumber;

    internal int IdNumber;
}
