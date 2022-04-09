using System;

namespace Aula8VS.src
{

    public class Televisão
    {
        public string Brand { get; set; }
        public string Resolution { get; set; }
        public int Value { get; set; }

        public Televisão()
        {

        }

        public Televisão(string _brand, string _resolution, int _value)
        {
            Brand = _brand;
            Resolution = _resolution;
            Value = _value;
        }

        public void Reso()
        {
            Console.WriteLine("A maioria das televisões possuem resoluções entre 4k a 2k, somente a da PHILCO que é FULL HD");
        }

        public void Assistir(string assistir)
        {
            Console.WriteLine($"Estão assistindo {assistir}");
        }
        public string Barulho()
        {
            return "plinnn.....";
        }

    }
}

