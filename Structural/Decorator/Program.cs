using Decorator;
using static System.Console;

var client = new Client();
var simple = new ConcreteComponent();

WriteLine("Client: I've got a simple component:");

client.ClientCode(simple);

WriteLine();

var decorator1 = new ConcreteDecoratorA(simple);
var decorator2 = new ConcreteDecoratorB(decorator1);

WriteLine("Client: Now I've got a decorated component:");

client.ClientCode(decorator2);

/*
 * Client: I get a simple component:
 * RESULT: ConcreteComponent
 * 
 * Client: Now I've got a decorated component:
 * RESULT: ConcreteDecoratorB(ConcreteDecoratorA(ConcreteComponent))
 */
