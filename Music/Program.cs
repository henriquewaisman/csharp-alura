Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
// bandasRegistradas.Add("Teste", new List<int> { 10, 4, 7 });

void Menu()
{
    Console.Clear();
    string mensagemDeBoasVindas = "Boas vindas ao ScreenSound";
    Console.WriteLine("**************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("**************************");
    OpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void OpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para motrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");
    var opcaoEscolhida = int.Parse(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: MediaDaBanda(); break;
        case 0: Console.WriteLine("END/"); break;
        default: DefaultOp(); break;
    }
}

Menu();

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    var nomeBanda = Console.ReadLine();
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"Banda {nomeBanda} registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
}

void MostrarBandas()
{
    ExibirTituloDaOpcao("Mostrando Lista de todas as bandas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("Digite uma tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Digite a nota que você deseja dar: ");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi dada à banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        OpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

void MediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Media da Banda");
    Console.Write("Digite o nome da banda: ");
    var nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        var media = Math.Round(bandasRegistradas[nomeDaBanda].Average(), 2);
        Console.WriteLine($"A banda {nomeDaBanda} tem média {media}\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu\n");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

void DefaultOp()
{
    Console.WriteLine("Opção inválida\nAperte qualquer botão para voltar ao Menu.");
    Console.ReadKey();
    Console.Clear();
    Menu();
}
