string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaBandas = new List<string>();
Dictionary<string, List<int>> bandasDicionarios = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(mensagemDeBoasVindas);

}
void ExibirOpcoesDoMenu()

{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("\nDigite 2 para mostrar todaas as bandas.");
    Console.WriteLine("\nDigite 3 para avaliar uma banda.");
    Console.WriteLine("\nDigite 4 para exibir a média de uma banda");
    Console.WriteLine("\nDigite -1 para sair.");

    Console.Write("\nDigite a opção escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoNumerica) 
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBanda();
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }

}
void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas.");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasDicionarios.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("\nExibindo todas as bandas registradas!");

    foreach (string banda in bandasDicionarios.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliar banda.");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasDicionarios.ContainsKey(nomeDaBanda))
    {
        Console.Write("Qual nota você quer atribuir a banda? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasDicionarios[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota da banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } 
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não exite em nossos registros.");
        Console.WriteLine("Digite alguma tecla para sair do programa.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


void MediaBanda()
{
    Console.Clear();
    Console.WriteLine("Média da banda.");

    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasDicionarios.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasDicionarios[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não exite em nossos registros.");
        Console.WriteLine("Digite alguma tecla para sair do programa.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}






ExibirLogo();
ExibirOpcoesDoMenu();

