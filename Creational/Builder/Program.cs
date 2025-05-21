using Builder;

var director = new Director();
var builder = new ConcreteBuilder();

director.Builder = builder;

Console.WriteLine("Standard basic product:");

director.BuildMinimalViableProduct();

Console.WriteLine(builder.GetProduct().ListParts());
Console.WriteLine("Standard full featured product:");

director.BuildFullFeaturedProduct();

Console.WriteLine(builder.GetProduct().ListParts());
Console.WriteLine("Custom product:");

builder.BuildPartA();
builder.BuildPartC();

Console.Write(builder.GetProduct().ListParts());

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
