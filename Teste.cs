//Código para somar todos os numeros impares
using System;

namespace Projetos
{
    class Teste
    {
        static void Tree(string[] args)
        {
            const int NI = 500;
            int result = 0, N;

            for (N = 0; N <= NI; N++)//Loop para contar do 1 ao 500
            {

                if (N % 3 == 0 && N % 2 != 0)
                {
                    result = result + N;
                    Console.WriteLine("Soma de Impares Atual: ", result);
                }

            }
            Console.WriteLine("O resultado é: " + result);
        }

    }
}