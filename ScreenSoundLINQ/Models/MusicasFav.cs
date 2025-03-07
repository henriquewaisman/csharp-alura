using System.Text.Json;

namespace ScreenSound_04.Models;
internal class MusicasFav
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasFav(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicas()
    {
        Console.WriteLine($"Musicas favoritas de {Nome}");
        int i = 0;
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            i++;
            Console.WriteLine($"{i} - {musica.Nome} - {musica.Artista}");
        }
    }
    public void ConverterJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string arquivo = $"musicas-fav-{Nome}.json";

        File.WriteAllText(arquivo, json);
        Console.WriteLine($"Arquivo criado em {Path.GetFullPath(arquivo)}");
    }
}