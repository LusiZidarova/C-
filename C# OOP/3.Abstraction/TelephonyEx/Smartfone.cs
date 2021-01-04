using System;
using System.Collections.Generic;
using System.Text;

namespace TelephonyEx
{
    public class Smartfone : ICallable, IBrowsable
    {
        public void Browse(string url)
        {
            Console.WriteLine($"Browsing... {url}");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
