
using VehiclesExtension_Ex.Core;

namespace VehiclesExtension_Ex
{
    class Program
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
