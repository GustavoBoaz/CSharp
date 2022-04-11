using System;

namespace Aula7VSC
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.WriteLine($"Resultado: {Somar(num1, num2)}");
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"Resultado: {Dividir(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Operador invalido");
                    break;
            }
            
        }

        public static string Somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

        public static string Subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }

        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }

        //METODO
        public static string Dividir(int num1, int num2)
        {
            if(valorDividendoMenorOuIgualQueZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }

            return (num1 / num2).ToString();

            //FUNCAO
            bool valorDividendoMenorOuIgualQueZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
