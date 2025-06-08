using Facade;

var subsystem1 = new Subsystem1();
var subsystem2 = new Subsystem2();
var facade = new Facade.Facade(subsystem1, subsystem2);

Client.ClientCode(facade);

/*
 * Facade initializes subsystems:
 * Subsystem1: Ready!
 * Subsystem2: Get ready!
 * Facade orders subsystems to perform the action:
 * Subsystem1: Go!
 * Subsystem2: Fire!
 */
