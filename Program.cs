using ScreenSound___API.Modelos;
using System.Text.Json;
using ScreenSound___API.filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasPorArtistas(musicas, "Kanye West");

        var musicasPreferidasDeNicholas = new MusicasPreferidas("Nicholas");
        musicasPreferidasDeNicholas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDeNicholas.AdicionarMusicasFavoritas(musicas[66]);
        musicasPreferidasDeNicholas.AdicionarMusicasFavoritas(musicas[567]);
        musicasPreferidasDeNicholas.AdicionarMusicasFavoritas(musicas[990]);
        musicasPreferidasDeNicholas.AdicionarMusicasFavoritas(musicas[1000]);

        musicasPreferidasDeNicholas.ExibirMusicasFavoritas();

        var musicasPreferidasDoBatman = new MusicasPreferidas("Batman");
        musicasPreferidasDoBatman.AdicionarMusicasFavoritas(musicas[320]);
        musicasPreferidasDoBatman.AdicionarMusicasFavoritas(musicas[230]);
        musicasPreferidasDoBatman.AdicionarMusicasFavoritas(musicas[122]);
        musicasPreferidasDoBatman.AdicionarMusicasFavoritas(musicas[876]);
        musicasPreferidasDoBatman.AdicionarMusicasFavoritas(musicas[663]);

        musicasPreferidasDoBatman.ExibirMusicasFavoritas();

        musicasPreferidasDoBatman.GerarArquivoJSON();

    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    } 
}