using System;

namespace Aula5VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você concluiu o curso (sim ou nao): ");
            string condicaoCursoConcluido = Console.ReadLine();

            Console.WriteLine("Quantos cursos você concluiu: ");
            int condicaoQuantidadeCursoConcluido = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Você pagou todo o curso (sim ou nao): ");
            string condicaoQuitacao = Console.ReadLine();

            Console.WriteLine("Você devolveu todos os livros da biblioteca (sim ou nao): ");
            string condicaoBiblioteca = Console.ReadLine();

            if (condicaoCursoConcluido == "sim" &&
                condicaoQuantidadeCursoConcluido >= 25 &&
                condicaoQuitacao == "sim" &&
                condicaoBiblioteca == "sim")
            {
                Console.WriteLine("PODE COLAR GRAU");
            }
            else
            {
                Console.WriteLine("NÃO COLA GRAU");
            }
        }
    }
}
