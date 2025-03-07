using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Exe1();
        // Exe2();
        // Exe3();
        // Exe4();
    }
    public static void Exe1()
    {
        List<int> numeros = new List<int> { 25, 29, 9, 28, 7, 19, 1, 28, 2, 5, 1, 29, 26, 6, 20 };

        var numerosDistitos = numeros.Order().Distinct();
        foreach (var numero in numerosDistitos)
        {
            Console.Write(numero + " ");
        }
    }

    public static void Exe2()
    {
        //Lista gerada por IA 
        List<Livro> livros = new List<Livro>
        {
            new Livro("1984", "George Orwell", 1949),
            new Livro("Dom Quixote", "Miguel de Cervantes", 1605),
            new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954),
            new Livro("Cem Anos de Solidão", "Gabriel García Márquez", 1967),
            new Livro("Orgulho e Preconceito", "Jane Austen", 1813),
            new Livro("Crime e Castigo", "Fiódor Dostoiévski", 1866),
            new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943),
            new Livro("A Revolução dos Bichos", "George Orwell", 1945),
            new Livro("O Grande Gatsby", "F. Scott Fitzgerald", 1925),
            new Livro("A Metamorfose", "Franz Kafka", 1915),
            new Livro("Os Miseráveis", "Victor Hugo", 1862),
            new Livro("Ulisses", "James Joyce", 1922),
            new Livro("A Menina que Roubava Livros", "Markus Zusak", 2005),
            new Livro("O Código Da Vinci", "Dan Brown", 2003),
            new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 1997),
            new Livro("A Culpa é das Estrelas", "John Green", 2012),
            new Livro("Sapiens: Uma Breve História da Humanidade", "Yuval Noah Harari", 2011),
            new Livro("O Orfanato da Srta. Peregrine para Crianças Peculiares", "Ransom Riggs", 2011)
        };

        var livrosDoisMil = livros.Where(livro => livro.AnoPublicacao >= 2000)
        .Select(livro => livro.Titulo).Order();
        foreach (var livro in livrosDoisMil)
        {
            Console.WriteLine(livro);
        }
    }

    public static void Exe3()
    {
        //Lista gerada por IA
        List<Produto> produtos = new List<Produto>
        {
            new Produto("Notebook Dell Inspiron", 4500.00),
            new Produto("Smartphone Samsung Galaxy S23", 3800.00),
            new Produto("Fone de Ouvido Bluetooth JBL", 250.00),
            new Produto("Monitor LG Ultrawide 29”", 1500.00),
            new Produto("Teclado Mecânico Redragon", 300.00),
            new Produto("Mouse Gamer Logitech G502", 350.00),
            new Produto("Cadeira Gamer DXRacer", 1200.00),
            new Produto("SSD Kingston 1TB NVMe", 500.00),
            new Produto("Smartwatch Apple Watch Series 9", 3200.00),
            new Produto("Console PlayStation 5", 4000.00)
        };
        var precoMedio = produtos.Average(produto => produto.Preco);
        Console.WriteLine("Média dos preços: " + precoMedio.ToString("F2", CultureInfo.InvariantCulture));
    }

    public static void Exe4()
    {
        List<int> inteiros = new List<int> { 27, 13, 7, 21, 10, 11, 24, 19, 11, 4, 4, 20, 2, 24, 18 };

        var pares = inteiros.Where(inteiro => inteiro % 2 == 0);

        foreach (var num in pares)
        {
            Console.Write(num + " ");
        }
    }
}
