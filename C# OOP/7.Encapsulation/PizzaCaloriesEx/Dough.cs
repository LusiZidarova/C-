using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories_Ex
{
	public class Dough
	{
		private const double BaseCaloriesPerGram = 2;
	//	private const double MinGrams = 0;
		private readonly Dictionary<string, double> DefaultFlourTypes = new Dictionary<string, double>
		{
			{"white",1.5 },
			{"wholegrain",1.0 }
		};
		private readonly Dictionary<string, double> DefaultBakingTechnique = new Dictionary<string, double>
		{
			{"crispy",0.9 },
			{"chewy",1.1 },
			{"homemade",1.0}
		};
		private string flourType;
		private string bakingTechnique;
		private double grams;
		public Dough(string flourType, string bakingTechnique, double grams)
		{
			this.FlourType = flourType.ToLower();
			this.BakingTechnique = bakingTechnique.ToLower();
			this.Grams = grams;
		}

		public string FlourType
		{
			get { return flourType; }
			private set {
				if (!this.DefaultFlourTypes.ContainsKey(value)){
					throw new ArgumentException($"Invalid flour type {value}");
				}
				this.flourType = value.ToLower();
			}
		}


		public string BakingTechnique
		{
			get { return bakingTechnique; }
			private set {
				if (!this.DefaultBakingTechnique.ContainsKey(value))
				{
					throw new ArgumentException($"Invalid Baking Technique {value}!");
				}
				this.bakingTechnique = value; }
		}



		public double Grams
		{
			get { return grams; }
			private set
			{
				if (value < 1 || value > 200)
				{
					throw new ArgumentException("Dough weight should be in the range [1..200].");
				}
				this.grams = value; }
		}

		public double CaloriesPerGram => BaseCaloriesPerGram *
										 this.DefaultFlourTypes[this.FlourType] *
										 this.DefaultBakingTechnique[this.BakingTechnique]*
										 this.Grams;
	}

}
