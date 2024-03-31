using System.Text.Json;
namespace ScreenSound___API.Modelos;

internal class MusicasPreferidas
{
    public string? Nome {  get; set; }
    public List<Musica> ListaDeMusicaFavoritas { get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicaFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicaFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}");
        foreach (var item in ListaDeMusicaFavoritas)
        {
            Console.WriteLine($"- {item.Nome} de {item.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJSON()
    {
        string json = JsonSerializer.Serialize(new
        {
            Nome = Nome,
            musicas = ListaDeMusicaFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json criado com sucesso no local {Path.GetFullPath(nomeDoArquivo)}");
    }
}
