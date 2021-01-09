using System;
using WildFarm_Ex.Models;

namespace WildFarm_Ex.Factories
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string[] args)
        {
            string typeAnimal = args[0];

            switch (args[0])
            {
                case nameof(Hen):
                    //Birds - "{Type} {Name} {Weight} {WingSize}";
                    return new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
                case nameof(Owl):
                    return new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
                case nameof(Mouse):
                   // Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";
                    return new Mouse(args[1], double.Parse(args[2]), args[3]);
                case nameof(Dog):
                    //Birds - "{Type} {Name} {Weight} {WingSize}";
                    return new Dog(args[1], double.Parse(args[2]), args[3]);
                case nameof(Cat):
                    //Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
                    return new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
                 case nameof(Tiger):
                     return new Tiger(args[1], double.Parse(args[2]), args[3],args[4]);
                default:
                    throw new ArgumentException($"{typeAnimal} is not a valid Animal type.");
            }
        }
    }
}
