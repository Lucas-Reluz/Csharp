using System;
namespace Zoologico.src
{
    public class Cachorro : Animal
    {
        public Cachorro()
        {

        }
        public Cachorro(string nome, string cor, string classificacao) : base(nome, cor, classificacao)
        {
        
        }
        public override void Comunicar(string comunicacao)
        {
           Console.WriteLine($"{Nome} está falando {comunicacao}");
        }
    }
}