using Alura.Filmes;
class Program
{
    private static void Main(string[] args)
    {
        Artista ator1 = new Artista("Russell Crowe", 60);
        Artista ator2 = new Artista("Joaquin Phoenix", 60);
        Artista ator3 = new Artista("Al Pacino", 84);

        Filme filme1 = new Filme("Gladiador", 155, new List<Artista> { ator1, ator2 });

        Filme filme2 = new Filme("Poderoso Chefão", 175, null);

        Console.WriteLine("Elenco de Gladiador");
        filme1.ListarElenco();

        Console.WriteLine();
        filme2.AdicionarElenco(ator3);

        Console.WriteLine("\nElenco de Poderoso Chefão");
        filme2.ListarElenco();

        Console.WriteLine();
        ator1.MostrarFilmesAtuados();

    }

}
