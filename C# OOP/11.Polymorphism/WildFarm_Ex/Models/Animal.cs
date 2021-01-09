using System;
using WildFarm_Ex.Foods;

namespace WildFarm_Ex.Models
{
    public abstract class Animal 
    {
        //Animal – string Name, double Weight, int FoodEaten;
        public string Name { get; set; }
        public double Weight { get; private set; }

       public Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public int FoodEaten { get; set; }

        protected abstract double WeightPerFood { get; }
        public virtual void EatFood(Food food) {
            ValidateFood(food);
            this.FoodEaten += food.Quantity;
        }
        public abstract string Sound();

        protected void CheckFood(Food food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        protected abstract void ValidateFood(Food food);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }

    }
}
