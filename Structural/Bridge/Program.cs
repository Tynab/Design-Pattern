using Bridge;
using static System.Console;

Client client = new();
Abstraction abstraction;

abstraction = new(new ConcreteImplementationA());
client.ClientCode(abstraction);

WriteLine();

abstraction = new(new ConcreteImplementationB());
client.ClientCode(abstraction);

/*
 * Abstract: Base operation with:
 * ConcreteImplementationA: The result in platform A.
 * 
 * ExtendedAbstraction: Extended operation with:
 * ConcreteImplementationA: The result in platform B.
 */
