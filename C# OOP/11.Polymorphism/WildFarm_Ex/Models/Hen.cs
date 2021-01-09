
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) :
          base(name, weight, wingSize)
        {

        }

        protected override double WeightPerFood => 0.35;
        public override string Sound()
        {
            return "Cluck";
        }

        protected override void ValidateFood(Food food)
        {
           
        }
    }
}
