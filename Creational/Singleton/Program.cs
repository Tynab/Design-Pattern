using static Singleton.Singleton;
using static System.Console;

var s1 = GetInstance();
var s2 = GetInstance();

if (s1 == s2)
{
    WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    WriteLine("Singleton failed, variables contain different instances.");
}

/*
 * Singleton works, both variables contain the same instance.
 */
