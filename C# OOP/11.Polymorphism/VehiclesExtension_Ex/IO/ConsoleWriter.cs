using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension_Ex.IO
{
    public class ConsoleWriter : IWriter
    {
        public void CustomWrite(string text)
        {
            Console.WriteLine(text);
        }

        public void CustomWriteline(string text)
        {
            Console.Write(text);
        }
    }
}
