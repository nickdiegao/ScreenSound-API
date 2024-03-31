using ScreenSound___API.Modelos;

namespace ScreenSound___API.filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var item in artistasOrdenados)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
