using System;
namespace Zoologico.src
{
    public class Macaco : Animal
    {
        public Macaco(string nome, string cor, string classificacao) : base(nome, cor, classificacao)
        {

        }
        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando {comunicacao}");
        }
    }
}