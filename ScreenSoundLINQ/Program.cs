using System.Text.Json;
using ScreenSound_04.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // musicas[0].ExibirDetalhes();
        // LinqFilter.FiltrarGeneros(musicas);
        // LinqFilter.OrdenarArtistas(musicas);
        // LinqFilter.ArtistaPorGenero(musicas, "rock");
        // LinqFilter.MusicasPorArtista(musicas, "Eminem");

        // var favDoFulano = new MusicasFav("Fulano");
        // favDoFulano.AdicionarMusicasFavoritas(musicas[1]);
        // favDoFulano.AdicionarMusicasFavoritas(musicas[2]);
        // favDoFulano.AdicionarMusicasFavoritas(musicas[3]);
        // favDoFulano.AdicionarMusicasFavoritas(musicas[4]);
        // favDoFulano.AdicionarMusicasFavoritas(musicas[5]);

        // favDoFulano.ExibirMusicas();

        // favDoFulano.ConverterJson();
        // musicas[0].ExibirDetalhes();

        LinqFilter.CsharpMusicas(musicas);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

