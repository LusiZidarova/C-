using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
   public  class Cat : Feline
    {

        public Cat(string name, double weight, string livingRegion,string breed)
         : base(name, weight, livingRegion,breed)
        {

        }
        protected override double WeightPerFood => 0.30;
        public override string Sound()
        {
            return "Meow"; 
        }

        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Meat) && food.GetType().Name != nameof(Vegetable))
            {
                this.CheckFood(food);
            }
        }

    }
}
