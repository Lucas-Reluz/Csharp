using System;

namespace Aula3
{
    public class IMC
    {
        static void Main(string[] args)
        {

            Console.Write("Qual seu nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite sua Altura (por favor utilize virgula): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double IMC = weight / (height * height);
            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (IMC < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}