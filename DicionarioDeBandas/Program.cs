string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaBandas = new List<string>();

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
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Bye-Bye :)");
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
    listaBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("\nExibindo todas as bandas registradas!");
   //for (int i = 0; i < listaBandas.Count; i++)
    //{
      //  Console.WriteLine($"Banda:: {listaBandas[i]}");
    //}
    foreach (string banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}








ExibirLogo();
ExibirOpcoesDoMenu();

