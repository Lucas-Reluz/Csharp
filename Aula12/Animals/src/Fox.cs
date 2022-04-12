using System;
namespace Animals.src
{
    public class Fox : Animal
    {
        public Fox(string name, string color, string curiosity) : base(name, color, curiosity)
        {

        }
        public override void Sound(string sound)
        {
            Console.WriteLine($"the sound of the {Name} is like this {sound}");
        }
    }
}