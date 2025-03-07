using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

internal class Filme
{
    [JsonPropertyName("title")]
    public string Titulo { get; set; }

    [JsonPropertyName("year")]
    public string AnoLancamento { get; set; }

    [JsonPropertyName("crew")]
    public string Elenco { get; set; }

    [JsonPropertyName("imDbRating")]
    public string Nota { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Titulo} ({AnoLancamento})");
        Console.WriteLine($"Elenco: {Elenco}");
        Console.WriteLine($"Nota: {Nota}");
    }
}