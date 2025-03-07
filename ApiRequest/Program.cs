using System.Text.Json;
using ScreenSound_04.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhes();

        /// Exercicio
        string respostaFilme = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filme = JsonSerializer.Deserialize<List<Filme>>(respostaFilme);
        filme[0].ExibirDetalhes();

        string respostaPais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var pais = JsonSerializer.Deserialize<List<Pais>>(respostaPais);
        pais[0].ExibirDetalhes();

        string respostaCarro = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carro = JsonSerializer.Deserialize<List<Carro>>(respostaCarro);
        carro[0].ExibirDetalhes();

        string respostaLivro = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livro = JsonSerializer.Deserialize<List<Livro>>(respostaLivro);
        livro[0].ExibirDetalhes();

        string respostaPersonagem = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
        var personagem = JsonSerializer.Deserialize<Personagem>(respostaPersonagem);
        personagem.ExibirDetalhes();

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
