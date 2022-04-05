using System;

namespace Aula5VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor vendido mensal: ");
            double valorVendido = double.Parse(Console.ReadLine());

            if(valorVendido <= 10000)
            {
                Console.WriteLine("O valor a receber: R$ " + (valorVendido * 0.01));
            }
            else if (valorVendido <= 20000)
            {
                Console.WriteLine("O valor a receber: R$ " + (valorVendido * 0.02));
            }
            else if (valorVendido <= 30000)
            {
                Console.WriteLine("O valor a receber: R$ " + (valorVendido * 0.03));
            }
            else
            {
                Console.WriteLine("O valor a receber: R$ " + (valorVendido * 0.1));
            }

        }
    }
}
