
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
    public class Owl :Bird
    {

        public Owl(string name,double  weight,double wingSize) :
            base(name, weight,wingSize)
        {

        }

        protected override double WeightPerFood => 0.25;
        public override string Sound()
        {
            return "Hoot Hoot";
        }

        protected override void ValidateFood(Food food)
        {
            if(food.GetType().Name != nameof(Meat))
            {
                this.CheckFood(food);
            }
        }

    }
}
