
void TelaInicial()
{
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");

    Console.WriteLine(@"Bem vindo ao Screen Sound 💀");
}

void Menu()
{
    Console.WriteLine("\nDigite 1 para resgistrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerico = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerico)
    {
        case 1: Console.WriteLine("Você digitou a opção " +  opcaoEscolhidaNumerico);
            break;
        case 2: Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerico);
            break;
        case 3: Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerico);
            break;
        case 4:Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerico);
            break;
        case -1: Console.WriteLine("Programa encerrado");
            break;
        default: Console.WriteLine("Opação invalida");
            break;
    }
}

TelaInicial();
Menu();
