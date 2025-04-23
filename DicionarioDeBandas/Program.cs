string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
void ExibirMensagensDeBoasVindas()
{
    Console.WriteLine(mensagemDeBoasVindas);

}
void ExibirOpcoesDoMenu()
{
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
        case 1: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }

}

ExibirMensagensDeBoasVindas();
ExibirOpcoesDoMenu();
