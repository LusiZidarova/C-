using System;
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
    public class Bird : Animal
    {
        public double WingSize { get; set; }

        protected override double WeightPerFood { get; }

        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSize}, {Weight + FoodEaten*WeightPerFood}, {FoodEaten}]";
        }

        /*
        public override string Sound()
        {
            throw new NotImplementedException();
        }

        protected override void ValidateFood(Food food)
        {
            throw new NotImplementedException();
        }
        */
    }
}
