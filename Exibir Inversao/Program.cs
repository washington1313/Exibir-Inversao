using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exibir_Inversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomesEntrada = new string[5];
            int totalNomes = nomesEntrada.Length;

            for (int i = 0; i < nomesEntrada.Length; i++)
            {
                Console.WriteLine("Digite os nomes: ");
                nomesEntrada[i] = Console.ReadLine();

                Console.Clear();
            }

            for (int i = 0; i < totalNomes; i++)
            {
                Console.WriteLine("Nomes exibidos em ordem de cadastro: " + nomesEntrada[i]);
            }

            for (int i = totalNomes - 1; i >= 0; i--)
            {
                Console.WriteLine("Nomes exibidos em ordem contraria: " + nomesEntrada[i]);
            }

            Console.ReadKey();
        }
    }
}
