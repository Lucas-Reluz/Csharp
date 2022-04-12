using System;
using Calculadora.src;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo triangulo = new Triangulo("triangulo", 50, 30);
            Quadrado quadrado = new Quadrado("quadrado", 45, 34.7);
            Retangulo retangulo = new Retangulo("retangulo", 23, 42.8);

            Console.WriteLine($"O {triangulo.Nome} tem uma base de valor {triangulo.Base} e altura de valor {triangulo.Altura} e sua área é {triangulo.CalcularArea()}");
            Console.WriteLine($"O {quadrado.Nome} tem uma base de valor {quadrado.Base} e altura de valor {quadrado.Altura} e sua área é {quadrado.CalcularArea()}");
            Console.WriteLine($"O {retangulo.Nome} tem uma base de valor {retangulo.Base} e altura de valor {retangulo.Altura} e sua área é({retangulo.CalcularArea()}");
        }
    }
}
