using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    [JsonPropertyName("motor")]
    public string Motor { get; set; }

    [JsonPropertyName("transmissao")]
    public string Transmissao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Marca} {Modelo} {Ano}");
        Console.WriteLine($"Motor: {Motor}\nTransmissão: {Transmissao}");
    }
}