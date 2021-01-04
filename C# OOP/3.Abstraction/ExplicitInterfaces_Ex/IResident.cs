using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces_Ex
{
    public interface IResident
    {
        string Name { get; }
        string Country { get; }

        string GetName();
    }
}
