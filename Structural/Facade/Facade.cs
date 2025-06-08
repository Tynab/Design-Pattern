namespace Facade;

internal sealed class Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
{
    private readonly Subsystem1 _subsystem1 = subsystem1;
    private readonly Subsystem2 _subsystem2 = subsystem2;

    internal string Operation()
    {
        var result = "Facade initializes subsystems:\n";

        result += _subsystem1.Operation1();
        result += _subsystem2.Operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += _subsystem1.OperationN();
        result += _subsystem2.OperationZ();

        return result;
    }
}
