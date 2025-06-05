using Adapter;
using static System.Console;

var adaptee = new Adaptee();
ITarget target = new Adapter.Adapter(adaptee);

WriteLine("Adaptee interface is incompatible with the client.");
WriteLine("But with adapter client can call it's method.");
WriteLine(target.GetRequest());

/*
 * Adaptee interface is incompatible with the client.
 * But with adapter client can call it's method.
 * This is 'Specific request.'
 */
