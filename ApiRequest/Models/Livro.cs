using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int AnoLancamento { get; set; }

    [JsonPropertyName("genero")]
    public string Genero { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Titulo} ({AnoLancamento})");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}