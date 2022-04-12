using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoologico");

            List<Animal> animais = new List<Animal>(
                    new Animal[]{
                        new Gato("Gato Catel", "Cinza", "Felino"),
                        new Cachorro("Cachorro Rodrigo", "Preto", "Canidio"),
                        new Cachorro("Cachorro Bueno", "Branco", "Canídio"),
                        new Gato("Gato Cavalcanti", "Marrom", "Felino")
                        }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                }
                else if (animal.Classificacao == "Felino")
                {
                Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                animal.Comunicar("Miauuuuuu!");
                }
            }

        }
    }
}