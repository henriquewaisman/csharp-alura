using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

internal class Musica
{
    private string[] tons = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade
    {
        get
        {
            return tons[Key];
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}