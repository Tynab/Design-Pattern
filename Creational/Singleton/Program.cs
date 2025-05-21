var s1 = Singleton.Singleton.GetInstance();
var s2 = Singleton.Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}

/*
 * Singleton works, both variables contain the same instance.
 */
