using Prototype;

var p1 = new Person
{
    Age = 42,
    BirthDate = Convert.ToDateTime("1977-01-01"),
    Name = "Jack Daniels",
    IdInfo = new IdInfo(666)
};

var p2 = p1.ShallowCopy();
var p3 = p1.DeepCopy();

Console.WriteLine("Original values of p1, p2, p3:");
Console.WriteLine("   p1 instance values: ");

DisplayValues(p1);

Console.WriteLine("   p2 instance values:");

DisplayValues(p2);

Console.WriteLine("   p3 instance values:");

DisplayValues(p3);

p1.Age = 32;
p1.BirthDate = Convert.ToDateTime("1900-01-01");
p1.Name = "Frank";
p1.IdInfo.IdNumber = 7878;

Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
Console.WriteLine("   p1 instance values: ");

DisplayValues(p1);

Console.WriteLine("   p2 instance values (reference values have changed):");

DisplayValues(p2);

Console.WriteLine("   p3 instance values (everything was kept the same):");

DisplayValues(p3);

static void DisplayValues(Person p)
{
    Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p.Name, p.Age, p.BirthDate);

    if (p.IdInfo is not null)
    {
        Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
    }
}

/*
 * Original values of p1, p2, p3:
 *  p1 instance values: 
 *      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
 *      ID#: 666
 *  p2 instance values:
 *      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
 *      ID#: 666
 *  p3 instance values:
 *      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
 *      ID#: 666
 * 
 * Values of p1, p2 and p3 after changes to p1:
 *  p1 instance values: 
 *      Name: Frank, Age: 32, BirthDate: 01/01/00
 *      ID#: 7878
 *  p2 instance values (reference values have changed):
 *      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
 *      ID#: 7878
 *  p3 instance values (everything was kept the same):
 *      Name: Jack Daniels, Age: 42, BirthDate: 01/01/77
 *      ID#: 666
 */
