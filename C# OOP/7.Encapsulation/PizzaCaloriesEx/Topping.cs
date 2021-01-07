using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories_Ex
{
    class Topping
    {
        private readonly Dictionary<string, double> DefaultTopping = new Dictionary<string, double>
        {
            {"Meat",1.2 },
            {"Veggies",0.8 },
            {"Cheese",1.1 },
            {"Sauce",0.9 }
        };
        private const double BaseCaloriesPerGram = 2;
        private string typeTopping;
        private double weight;

        public Topping(string topping, double weight)
        {
            this.TypeTopping = char.ToUpper(topping[0]) + topping.Substring(1); 
            this.Weight = weight;
        }

        public string TypeTopping
        {
            get { return typeTopping; }
            private set {
                if (!DefaultTopping.ContainsKey(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.typeTopping = value; 
            }
        }
        public double Weight
        {
            get { return weight; }
            private set {
                if (value<1 || value >50)
                {
                    throw new ArgumentException($"{this.TypeTopping} weight should be in the range[1..50].");
                }
                this.weight = value; 
            }
        }

        public double CaloriesPerGram => BaseCaloriesPerGram *
                                         this.DefaultTopping[this.TypeTopping] *
                                         this.Weight;
    }

    internal class CultureInfo
    {
        internal static readonly object CurrentCulture;
    }
}
