using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces_Ex
{
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
        string GetName();
    }
}
