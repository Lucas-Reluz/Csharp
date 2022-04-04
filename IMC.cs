using System;

namespace Projetos_VSC
{
    public class IMC
    {
        static void Main(string[] args)
        {
        float altura, peso, IMC;

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua altura: ");
        altura = float.Parse(Console.ReadLine());

        Console.Write("Digite seu peso: ");
        peso = float.Parse(Console.ReadLine());

        IMC = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + IMC);

        }
    }
}