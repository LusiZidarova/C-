using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories_Ex
{
    class Pizza
    {
        private const int MaxNameLength = 15;
        private const int MinNameLength = 1;
        private const int MaxToppingsCount=10;

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set { 
                if(string.IsNullOrWhiteSpace(value) || value.Length < MinNameLength || value.Length > MaxNameLength)
                {
                    throw new ArgumentException($"Pizza name should be between {MinNameLength} and {MaxNameLength} symbols.");
                }
                this.name = value; 
            }
        }
        public Dough Dough
        {
            get { return dough; }
            set { this.dough = value; }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == MaxToppingsCount)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppingsCount}].");
            }
            this.toppings.Add(topping);
        }

        public double CalculateTotalCalories()
        {
            double res = this.Dough.CaloriesPerGram;

            foreach (Topping topping in this.toppings)
            {
                res += topping.CaloriesPerGram;
            }
            return res;
        }
    }
}
