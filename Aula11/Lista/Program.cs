using System;
using System.Collections
.Generic;
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista");

            List<string> lista = new List<string>();

            lista.Add("Yasmin");
            lista.Add("Karol");
            lista.Add("Correia");
            lista.Add("Kaique");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}


/* for(int i = 0; i  <4; i++)
Console.Write("Entre com o nome: ")
var nome = Console.ReadLine();
lista,Add(nome);

Console.WriteLine("Lista: ");
foreach(var item in lista){
 Console.WriteLine(item);   
}
  */