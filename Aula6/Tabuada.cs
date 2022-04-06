using System;

namespace Aula6
{
    public class Tabuada
    {
        #region TABUADA
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para ver a tabuada: ");
            int num = Int32.Parse(Console.ReadLine());

            for (int tab = 1; tab <= 10; tab++)
            {
                int result = tab * num;
                Console.WriteLine($" {num} x {tab} = {result}");
            }
        }
    }
}
#endregion
