using System;

namespace Aula6
{
    public class Exercicio3
    {
        static void Main(string[] args)
        {
            int valor = 0; 
            for (int i = 0; i <= 20; i++)
            {
                Console.Write($"Posição {i} Entre com o valor que deseja somar: ");
                valor += int.Parse(Console.ReadLine());
            }
        
        Console.WriteLine($"Somatoria: {valor*2}");

        }
    }
}