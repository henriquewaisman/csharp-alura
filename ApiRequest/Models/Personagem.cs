using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

class Personagem
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }

    [JsonPropertyName("culture")]
    public string Cultura { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} of {Cultura}");
    }
}