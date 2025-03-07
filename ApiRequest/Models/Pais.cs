using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

class Pais
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"País: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Idioma: {Idioma}");
        Console.WriteLine($"População: {Populacao / 100}");
    }
}