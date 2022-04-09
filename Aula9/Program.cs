using System;
using ProjetosVSC.Aula9.Gato;

namespace Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gato garfield = new Gato("Garfield", "Laranja", 29);
            Gato tomas = new Gato("Thomas", "Cinza", 32);
            Gato frajola = new Gato("Frajola", "Preto", 57);

            Console.WriteLine($"Gato 1 é o {garfield.Name} de cor {garfield.Color} e tem o tamanho de {garfield.Size}cm");
            Console.WriteLine($"Gato 2 é o {tomas.Name} de cor {tomas.Color} e tem o tamanho de {tomas.Size}cm");
            Console.WriteLine($"Gato 3 é o {frajola.Name} de cor {frajola.Color} e tem o tamanho de {frajola.Size}cm");

            garfield.comer("um danone");
            Console.WriteLine(garfield.ronronar());
            tomas.sleep();
        }
    }
}
