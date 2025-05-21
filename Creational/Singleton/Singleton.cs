using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton;

internal sealed record Singleton
{
    private static Singleton? _instance;

    private Singleton() { }

    internal static Singleton GetInstance()
    {
        _instance ??= new Singleton();

        return _instance;
    }
}
