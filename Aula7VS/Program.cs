using System;

namespace Aula7VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pesquisar");

            string[] noticias =
            {
                "Parcerias entre cantores brasileiros e gringos",
                "Seu guarda-roupa pessoal",
                "39 Famosos que ja eram ricos antes da fama",
                "Toyota fecha fábrica em Saão Bernardo do Campo após 60 anos",
                "O que sua posição de dormir diz sobre a sua saúde"
            };

            while (true)
            {
                Console.Write("Digite 0 para sair ou o que deseja pesquisar: ");
                string pesquisa = Console.ReadLine();
                if (pesquisa == "0")
                {
                    break;
                }
                buscarNoticias(pesquisa, noticias);
            }
            
        }

        public static void buscarNoticias(string pesquisa,string[] noticias)
        {
            for (int i = 0; i < noticias.Length; i++)
			{
                if (noticias[i].Contains(pesquisa))
                {
                    Console.WriteLine($"Noticia {i + 1}: {noticias[i]}");
                }
			}
        }
    }
}
