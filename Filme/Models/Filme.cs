using System.Reflection;

namespace Alura.Filmes;
class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; }


    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
            foreach (var artista in Elenco)
            {
                artista.AdicionarFilme(this);
            }
        }
        Titulo = titulo;
        Duracao = duracao;
    }

    public void ListarElenco()
    {
        if (Elenco != null)
        {
            foreach (var artista in Elenco)
            {
                Console.Write(artista.Nome + "\n");
            }
        }
    }
    public void AdicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.Filmes.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"Artista {artista.Nome} adicionado ao elenco.");
    }


}
