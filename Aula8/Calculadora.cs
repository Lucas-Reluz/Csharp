using System;

namespace ProjetosVSC
    {
        class Calculadora
        {
            static void Main(string[] args)
            {
                Console.Write("Para ligar a calculadora digite switchon, para desligar digite switchoff: ");
                string ligar = Console.ReadLine();

                while (ligar == ("switchon"))
                {
                    Console.WriteLine("Calculadora");
                    Console.Write("Digite o primeiro numero: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o operador: ");
                    string operador = Console.ReadLine();

                    Console.Write("Digite o segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operador)
                    {

                        case "+":
                            Console.WriteLine($"Resultado {Adição(num1, num2)}");
                            break;
                        case "-":
                            Console.WriteLine($"Resultado {Subtração(num1, num2)}");
                            break;
                        case "/":
                            Console.WriteLine($"Resultado: {Divisão(num1, num2)}");
                            break;
                        case "*":
                            Console.WriteLine($"Resultado: {Multiplicação(num1, num2)}");
                            break;
                    }
                    Console.Write("Pressione qualquer tecla para continuar ou switchoff para desligar: ");
                    string desligar = Console.ReadLine();

                    if (desligar == ("switchoff"))
                    {
                        break;
                    }
                }

            }
            public static string Adição(int num1, int num2)
            {
                return (num1 + num2).ToString();
            }
            public static string Subtração(int num1, int num2)
            {
                return (num1 - num2).ToString();
            }
            public static string Divisão(int num1, int num2)
            {
                if (divisao0(num2))
                {
                    return "Não é possível dividir por zero";
                }
                return (num1 / num2).ToString();

                bool divisao0(int num2)
                {
                    if (num1 <= 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            public static string Multiplicação(int num1, int num2)
            {
                return (num1 * num2).ToString();
            }
        }
    }