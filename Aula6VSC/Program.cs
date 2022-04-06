using System;

namespace Aula6VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            for(int b = 1; b <= 10; b++)
            {
                for(int p = 1; p <= 10; p++)
                {
                    Console.WriteLine($"{b} x {p} = {b*p}");
                }
            }
        }
    }
}
