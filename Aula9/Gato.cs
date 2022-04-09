using System;

namespace ProjetosVSC.Aula9.Gato
{
    public class Gato
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }

        public Gato()
        {

        }

        public Gato(string _name, string _color, int _size)
        {
            Name = _name;
            Color = _color;
            Size = _size;
        }

        public void sleep()
        {
            Console.WriteLine("ZzZzZzZzZz...");
        }

        public void comer(string comida)
        {
            Console.WriteLine($"Estou comendo {comida}");
        }
        public string ronronar()
        {
            return "Ronroneando.......rrrrrr";
        }
    }

}
