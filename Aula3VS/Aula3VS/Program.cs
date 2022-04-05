using System;

namespace Aula3VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;


            Console.WriteLine("Entre com seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua idade: ");
            idade = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Oi " + nome + "\nQue legal que você tem " + idade + "anos de idade");
        }
    }
}
