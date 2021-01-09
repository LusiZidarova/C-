using System;
using System.Collections.Generic;
using WildFarm_Ex.Factories;
using WildFarm_Ex.Models;
using WildFarm_Ex.Foods;

namespace WildFarm_Ex
{
    class Program
    {
        static void Main()
        {

            List<Animal> animals = new List<Animal>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            
            {
                Animal animal = AnimalFactory.CreateAnimal(input.Split(' '));
                animals.Add(animal);
                Console.WriteLine(animal.Sound());
                Food food = FoodFactory.CreateFood(Console.ReadLine().Split(" "));

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}

/*
Wild Farm
Your task is to create a class hierarchy like the described below. The Animal, Bird, Mammal, Feline and Food classes should be abstract. Override the method ToString().
Food – int Quantity;
Vegetable;
Fruit;
Meat;
Seeds;
Animal – string Name, double Weight, int FoodEaten;
Bird – double WingSize;
  Owl;
  Hen;
Mammal – string LivingRegion;
  Mouse;
  Dog;
  Feline – string Breed;
    Cat;
    Tiger;
All animals should also have the ability to ask for food by producing a sound.
Owl – "Hoot Hoot";
Hen – "Cluck";
Mouse – "Squeak";
Dog – "Woof!";
Cat – "Meow";
Tiger – "ROAR!!!";
Now use the classes that you have created to instantiate some animals and feed them.
Input should be read from the console. Every even line (starting from 0) will contain information about an animal in the following format:
Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
Birds - "{Type} {Name} {Weight} {WingSize}";
Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";
On the odd lines, you will receive information about a piece of food that you should give to that animal. The line will consist of a FoodType and quantity, separated by a whitespace.
Animals will only eat a certain type of food, as follows:
Hens eat everything;
Mice eat vegetables and fruits;
Cats eat vegetables and meat;
Tigers, Dogs and Owls eat only meat;
If you try to give an animal a different type of food, it will not eat it and you should print:
"{AnimalType} does not eat {FoodType}!"
The weight of an animal will increase with every piece of food it eats, as follows:
Hen – 0.35;
Owl – 0.25;
Mouse – 0.10;
Cat – 0.30;
Dog – 0.40;
Tiger – 1.00;
Override the ToString() method to print the information about an animal in the formats:
Birds – "{AnimalType} [{AnimalName}, {WingSize}, {AnimalWeight}, {FoodEaten}]"
Felines – "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"
Mice and Dogs – "{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"
After you have read the information about the animal and the food, the animal will produce a sound (print it on the console). Next, you should try to feed it. After receiving the “End” command, print information about every animal in order of input.

Input	
Cat Pesho 1.1 Home Persian
Vegetable 4
End	

Output
Meow
Cat [Pesho, Persian, 2.3, Home, 4]

    Input
Tiger Typcho 167.7 Asia Bengal
Vegetable 1
Dog Doncho 500 Street 
Vegetable 150
End	

Output
ROAR!!!
Tiger does not eat Vegetable!
Woof!
Dog does not eat Vegetable!
Tiger [Typcho, Bengal, 167.7, Asia, 0]
Dog [Doncho, 500, Street, 0]

    Input
Mouse Jerry 0.5 Anywhere
Fruit 1000
Owl Toncho 2.5 30
Meat 5
End	

Output
Squeak
Hoot Hoot
Mouse [Jerry, 100.5, Anywhere, 1000]
Owl [Toncho, 30, 3.75, 5]

*/
