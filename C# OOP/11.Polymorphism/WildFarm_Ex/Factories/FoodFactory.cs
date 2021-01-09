using System;
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Factories
{
    public static class FoodFactory
    {
        public static Food CreateFood(string[] args)
        {
            string typeFood = args[0];
            int qty = int.Parse(args[1]);

            switch (args[0])
            {
                case nameof(Vegetable):
                    return new Vegetable(qty);
                case nameof(Fruit):
                    return new Fruit(qty);
                case nameof(Meat):
                    return new Meat(qty);
                case nameof(Seeds):
                    return new Seeds(qty);
                default:
                    throw new ArgumentException($"{typeFood} is not a valid Food");
            }
        }
    }
}
