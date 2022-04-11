using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gato Catel", "Cinza", "Felino"),
                    new Cachorro("Cachorro Rodrigo", "Preto", "Canídio"),
                    new Cachorro("Cachorro Bueno", "Branco", "Canídio"),
                    new Gato("Gato Cavalcanti", "Marrom", "Felino"),
                    new Macaco("Macaco Oliveira", "Marrom", "Primata"),
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                } 
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Huhu HAHA!");
                }
            }

        }
    }
}
