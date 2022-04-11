using System;
using Venda.src;

namespace Venda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Venda");

            VendedorA vendedorA = new VendedorA("João", 1000, 1000, "Vendedor");
            VendedorB vendedorB = new VendedorB("Maria", 2000, 2000, "Vendedor");

            Console.WriteLine(vendedorA);
            Console.WriteLine(vendedorB);
        }
    }
}
