

namespace WildFarm_Ex.Models
{
    public class Feline:Mammal
    {
        protected string Breed { get; private set; }

        public Feline(string name, double weight,string livingRegion, string breed)
           : base(name, weight,livingRegion)
        {
            this.Breed = breed;
        }

        public override string ToString()
        {
            //Felines – "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"

            return base.ToString() + $"{this.Breed}, {Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
