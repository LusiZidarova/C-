using System;
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
   public  class Mammal : Animal
    {
        //Mammal – string LivingRegion;

        protected string LivingRegion { get; private set;}

       
        public Mammal(string name, double weight, string livingRegion)
           : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

       protected override double WeightPerFood { get;}

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
