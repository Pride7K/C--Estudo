using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula2
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

            var musicas = new List<Musica>
            {
              new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
              new Musica { Id = 2, Nome = "I Shoot The Sheriff", GeneroId = 2},
              new Musica { Id = 3, Nome = "Danúbio Azul", GeneroId = 5},
            };

            var musicaquery = from m in musicas join g in generos on m.GeneroId equals g.Id select new { m,g};

            foreach(var musica in musicaquery)
            {
                Console.WriteLine(musica.m.Id + " " + musica.m.Nome + " " + musica.g.Nome);
            }

        }



    }

    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }
    }
}
