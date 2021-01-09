
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
          : base(name, weight, livingRegion)
        {

        }

        protected override double WeightPerFood => 0.40;
        public override string Sound()
        {
            return "Woof!";
        }

        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                this.CheckFood(food);
            }
        }
        public override string ToString()
        {

            return base.ToString() + $"{Weight + FoodEaten * WeightPerFood}, {this.LivingRegion}, {FoodEaten}]";
        }
    }
}
