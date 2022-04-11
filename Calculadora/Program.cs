using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            IOperacoes _objeto = new Calc();

            Console.WriteLine($"Soma: {_objeto.Somar(1, 2)}");
            Console.WriteLine($"Subtração: {_objeto.Subtrair(1, 2)}");
            Console.WriteLine($"Multiplicação: {_objeto.Multiplicar(1, 2)}");
            Console.WriteLine($"Divisão: {_objeto.Dividir(1, 2)}");
        }
    }
}
