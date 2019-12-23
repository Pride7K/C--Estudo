using Aula4.sla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Introdução ao link utlizando banco

            using (var contexto = new AluraTunesEntities())
            {
                //definição consulta
                var query = from g in contexto.Generos select g;

                foreach (var sla in query)
                {
                    Console.WriteLine(sla.GeneroId.ToString() + " " + sla.Nome);
                }
                //acessando dados e imprimindÕ

                Console.WriteLine( );

                var faixaegenero = from g in contexto.Generos join f in contexto.Faixas on g.GeneroId equals f.GeneroId select new { g, f };

                faixaegenero = faixaegenero.Take(10);

                contexto.Database.Log = Console.WriteLine;

                foreach(var elemento in faixaegenero)
                {
                    Console.WriteLine(elemento.f.Nome + " " + elemento.g.Nome ) ;
                }

                Console.ReadKey();

            }

            #endregion


            #region aula 05 Linq com where



            using (var contexto = new AluraTunesEntities())
            {
                var txtBusca = "Led";

                var artistas = from b in contexto.Artistas where b.Nome.Contains(txtBusca) select b;

                foreach(var artista in artistas)
                {
                    Console.WriteLine(artista.ArtistaId + " " + artista.Nome);
                }
            }

            #endregion


            #region aula 6 mesma coisa que a aula 5 porém usando Lambda expression(sintaxe de metodo para consulta)



            using(var contexto = new AluraTunesEntities())
            {

                var artistas = contexto.Artistas.Where(a => a.Nome.Contains("Led"));

                foreach(var artista in artistas)
                {
                    Console.WriteLine(artista.ArtistaId + " " + artista.Nome);
                }

            }

            #endregion


            #region aula 7 consulta com join

            using (var contexto = new AluraTunesEntities())
            {
                var query = from art in contexto.Artistas join alb in contexto.Albums on art.ArtistaId equals alb.ArtistaId where art.Nome.Contains("Led") select new { art, alb };


                foreach (var artista in query)
                {
                    Console.WriteLine(artista.art.ArtistaId + " " + artista.art.Nome + " " + artista.alb.Titulo);
                }

            }

            #endregion


            #region Aula 8 consulta sem join

            using (var contexto = new AluraTunesEntities())
            {
                var query = from alb in contexto.Albums where alb.Artista.Nome.Contains("Led") select new { NomeArtista = alb.Artista.Nome,NomeAlbum = alb.Titulo };

                foreach(var artista in query)
                {
                    Console.WriteLine(artista.NomeArtista + " " + artista.NomeAlbum);
                }

            }

            #endregion


            #region Aula 10 consulta com orderby

            using (var contexto = new AluraTunesEntities())
            {
                var query = from art in contexto.Artistas select art;

                query = query.OrderBy(q => q.Nome).ThenBy(p => p.ArtistaId);

                foreach(var artista in query)
                {
                    Console.WriteLine(artista.ArtistaId + " " + artista.Nome);
                }


            }

            #endregion

            #region Aula 11 Count


            using (var contexto = new AluraTunesEntities())
            {
                var query = from f in contexto.Faixas where f.Album.Artista.Nome == "Led Zeppelin" select f;

                var quantidade = query.Count();

                var metodo = contexto.Faixas.Where(p => p.Album.Artista.Nome == "Led Zeppelin").Count();

                Console.WriteLine($"Led Zeppelin tem {quantidade} músicas no banco de dados.");
                Console.WriteLine();
                Console.WriteLine($"Led Zeppelin tem {metodo} músicas no banco de dados.");
            }

            #endregion

            #region Aula 12 Sum

            using(var contexto = new AluraTunesEntities())
            {
                var query = from art in context
            }

            #endregion

            Console.ReadKey();
        }
    }
}
