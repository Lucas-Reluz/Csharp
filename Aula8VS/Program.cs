using System;
using Aula8VS.src;

namespace Aula8VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisão primeira = new Televisão("Samsung", "4K", 4000);
            Televisão segunda = new Televisão("LG", "2K", 2000);
            Televisão terceira = new Televisão("AOC", "2K", 2300);
            Televisão quarta = new Televisão("PHILCO", "FULL HD", 1800);

            Console.WriteLine($"A primeira televisão é da marca {primeira.Brand}, {primeira.Resolution} de resolução e custa {primeira.Value} ");
            Console.WriteLine($"A segunda televisão é da marca {segunda.Brand}, {segunda.Resolution} de resolução e custa {segunda.Value}");
            Console.WriteLine($"A terceira televisão é da marca {terceira.Brand}, {terceira.Resolution} de resolução e custa {terceira.Value}");
            Console.WriteLine($"A quarta televisão é da marca {quarta.Brand}, {quarta.Resolution} de resolução e custa {quarta.Value}");
           
            
            primeira.Reso();
            segunda.Assistir("Na segunda televisão Interestelar");
            Console.WriteLine(terceira.Barulho());
            quarta.Assistir("Na quarta televisão Um maluco no pedaço");
        }
    }
}
