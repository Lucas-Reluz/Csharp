using System;

namespace Aula5
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor vendido mensal: ");
            double valorVendido = double.Parse(Console.ReadLine());

            if (valorVendido <= 10000)
            {
                Console.WriteLine("valor a receber é: " + (valorVendido * 0.01));
            }
            else if (valorVendido <= 20000)
            {
                Console.WriteLine("Valor a receber é:" + (valorVendido * 0.02));
            }
            else if (valorVendido <= 30000)
            {
                Console.WriteLine("Valor a receber é:" + (valorVendido * 0.03));
            }
            else
            {
                Console.WriteLine("Valor a receber:" + (valorVendido * 0.01));
            }
        }
    }
}