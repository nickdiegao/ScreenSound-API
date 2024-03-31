using ScreenSound___API.Modelos;

namespace ScreenSound___API.filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo todos os artistas do genêro musical: {genero}");
        foreach (var item in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void FiltrarMusicasPorArtistas(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine(artista);
        foreach (var item in musicasPorArtista)
        {
            Console.WriteLine($"- {item.Nome}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();

        Console.WriteLine("Exibindo música em C#");
        foreach (var item in musicasEmCSharp)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
