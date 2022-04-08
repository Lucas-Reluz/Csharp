using System;

namespace Aula8VS.src
{

    public class Televisão
    {
        public string Brand { get; set; }
        public string Resolution { get; set; }
        public int    Value { get; set; }

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
        Console.WriteLine("Essa televisão é 4k ou 1440p");
    }

    public void Assistir(string assistir)
    {
        Console.WriteLine($"Nesta TV estão assistindo {assistir}");
    }
    public string Barulho()
    {
        return "plinnn.....";
    }
}
}

