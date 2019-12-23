using System;
using System.Xml.Linq;
using System.Linq;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xml = XElement.Load(@"Data\AluraTunes.xml");

            var query = from gen in xml.Elements("Generos").Elements("Genero") select gen;

            foreach (var genero in query)
            {
                Console.WriteLine(genero.Element("GeneroId").Value + " " + genero.Element("Nome").Value);
            }

            var musicaquery = from gen in xml.Elements("Generos").Elements("Genero") join m in xml.Elements("Musicas").Elements("Musica") on gen.Element("GeneroId").Value equals m.Element("GeneroId").Value select new { gen , m  };

            Console.WriteLine("");

            foreach(var genero in musicaquery)
            {
                Console.WriteLine(genero.gen.Element("GeneroId").Value + " " + genero.gen.Element("Nome").Value + " " + genero.m.Element("Nome").Value); ;
            }

        }
    }
}
