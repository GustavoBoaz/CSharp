using System;

namespace Aula3VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc);
        }
    }
}
