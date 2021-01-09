using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension_Ex.IO
{
    public interface IWriter
    {
        void CustomWriteline(string text);
        void CustomWrite(string text); 

    }
}
