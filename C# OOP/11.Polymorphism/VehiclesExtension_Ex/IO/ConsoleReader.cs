using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension_Ex.IO
{
    public class ConsoleReader : IReader
    {
        public string CustomeReadline()
        {
           return Console.ReadLine();
        }
    }
}
