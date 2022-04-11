using System;

namespace Aula8VS.src
{
    public class Gato
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        public Gato()
        {

        }

        public Gato(string _nome, string _cor, int _tamanho)
        {
            Nome = _nome;
            Cor = _cor;
            Tamanho = _tamanho;
        }

        public void dormir()
        {
            Console.WriteLine("ZzZzzzZz..");
        }

        public void comer(string comida)
        {
            Console.WriteLine($"Estou comendo {comida}");
        }

        public string ronronar()
        {
            return "Ronroneando...rrrrrrrrr";
        }
    }
}