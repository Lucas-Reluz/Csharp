using System;
namespace Animals.src
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Curiosity { get; set; }

        public Animal(string name, string color, string curiosity)
        {
            Name = name;
            Color = color;
            Curiosity = curiosity;
        }
        public virtual void Sound(string sound)
        {
        Console.WriteLine($"the sound of the {Name} is like this {sound}");
        }
    }

}