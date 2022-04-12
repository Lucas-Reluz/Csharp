using System;
using Animals.src;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoologico");

            List<Animal> animalss = new List<Animal>(new Animal[]{
            new Lion("Lion Alan", "Orange,", "He is the King of the Jungle."),
            new Bear("Bear Ted", "Brown,", "Bears pick up rocks to rub their faces."),
            new Crocodile("Crocodile Marquinhos", "Green,", "Crocodiles have 74 to 80 teeth."),
            new Fox ("Fox Zeca", "Red,", "Some foxes can hear objects that are 36.5 meters away.")
            });

            foreach (Animal animal in animalss)
            {
                if (animal.Color == "Red,")
                {
                    Console.WriteLine($"{animal.Name} color is {animal.Color} One of his curiosity is {animal.Curiosity}");
                    animal.Sound("Regougarrr....");
                }
                else if (animal.Color == "Orange,")
                {
                    Console.WriteLine($"{animal.Name} color is {animal.Color} One of his curiosity {animal.Curiosity}");
                    animal.Sound("ROOOARRRR....");
                }
                else if (animal.Color == "Brown,")
                {
                    Console.WriteLine($"{animal.Name} color is {animal.Color} One of his curiosity is {animal.Curiosity}");
                    animal.Sound("RUARRRRRRR....");
                }
                else if (animal.Color == "Green,")
                {
                Console.WriteLine($"{animal.Name} color is {animal.Color} One of his curiosity is {animal.Curiosity}");
                animal.Sound("ROOOOOOOOR.....");
                }

            }
        }
    }
}
