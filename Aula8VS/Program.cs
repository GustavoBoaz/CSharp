
using Aula8VS.src;
using System;

namespace Aula8VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato frajola;

            Gato garfield = new Gato("Garfild", "Laranja", 8);
            Gato tomas = new Gato("Thomas", "Cinza", 5);
            
            frajola = new Gato();
            frajola.Nome = "Frajola";
            frajola.Cor = "Preto";
            frajola.Tamanho = 4;

            Console.WriteLine($"Gato 1 é o {garfield.Nome} de cor {garfield.Cor} e tem o tamanho {garfield.Tamanho}");
            Console.WriteLine($"Gato 1 é o {tomas.Nome} de cor {tomas.Cor} e tem o tamanho {tomas.Tamanho}");
            Console.WriteLine($"Gato 1 é o {frajola.Nome} de cor {frajola.Cor} e tem o tamanho {frajola.Tamanho}");

            garfield.comer("Lazanha");
            tomas.dormir();
            string retorno = frajola.ronronar();
            Console.WriteLine(retorno);

        }
    }
}
