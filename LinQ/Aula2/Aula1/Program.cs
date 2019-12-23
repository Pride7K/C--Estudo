using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var generos = new List<Genero>
        {
            new Genero { Id = 1, Nome = "Rock"},
            new Genero { Id = 2, Nome =  "Reggae"},
            new Genero { Id = 3, Nome =  "Rock Progressivo"},
            new Genero { Id = 4, Nome =  "Punk"},
            new Genero { Id = 5, Nome =  "Clássica"}
        };

            var query = from gen in generos select gen;

            foreach (var geneross in query)
            {
                Console.WriteLine(geneross.Id + " " + geneross.Nome);
            }

            Console.WriteLine();

            var query2 = from gen in generos where gen.Nome.Contains("Rock") select gen;

            foreach (var geneross in query2)
            {
                Console.WriteLine(geneross.Id + " " + geneross.Nome);
            }

            Console.WriteLine();

            var query3 = from gen in generos where gen.Nome.Contains("Punk") select gen;

            foreach (var geneross in query3)
            {
                Console.WriteLine(geneross.Id + " " + geneross.Nome);
            }

        }
    }

    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
