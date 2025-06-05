using Builder;
using static System.Console;

var director = new Director();
var builder = new ConcreteBuilder();

director.Builder = builder;

WriteLine("Standard basic product:");

director.BuildMinimalViableProduct();

WriteLine(builder.GetProduct().ListParts());
WriteLine("Standard full featured product:");

director.BuildFullFeaturedProduct();

WriteLine(builder.GetProduct().ListParts());
WriteLine("Custom product:");

builder.BuildPartA();
builder.BuildPartC();

Write(builder.GetProduct().ListParts());

/*
 * Standard basic product:
 * Product parts: PartA1
 * 
 * Standard full featured product:
 * Product parts: PartA1, PartB1, PartC1
 * 
 * Custom product:
 * Product parts: PartA1, PartC1
 */
