using System;
namespace Zoologico.src
{
    public class Gato : Animal
    {
        public Gato()
        {

        }
        public Gato(string nome, string cor, string classificacao) : base(nome, cor, classificacao)
        {

        }
        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando {comunicacao}");

        }
    }
}