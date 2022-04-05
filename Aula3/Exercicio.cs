using System;

namespace Projetos_VSC
{
    public class Program
    {
        static void N(string[] args)
        {
        

            Console.WriteLine("Você concluiu o curso? (Sim ou Nao) ");
            string condicaoCC = Console.ReadLine();
            Console.WriteLine("Quantos Cursos você concluiu? ");
            int condicaoQCC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Você quitou o curso? (sim ou nao) ");
            string condicaoQTC = Console.ReadLine();
            Console.WriteLine("Você devolveu todos os livros? (sim ou nao)");
            string condicaoB = Console.ReadLine();
            
            if(condicaoCC == "sim" &&
            condicaoQCC >= 25 &&
            condicaoQTC == "sim" &&
            condicaoB == "sim")
            {
                Console.Write("APROVADO!");

            }
            else
            {
                Console.WriteLine("NÃO APROVADO");
            }
        }
    }
}