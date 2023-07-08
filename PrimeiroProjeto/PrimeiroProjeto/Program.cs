
//List<string> listaBandas = new List<string> {"U2", "Beatles", "AC/DC" };
Dictionary<string,List<int>> listaBandasRegistradas = new Dictionary<string,List<int>>();
listaBandasRegistradas.Add("Linkin park", new List<int>{10, 9, 9});
listaBandasRegistradas.Add("U2", new List<int> { 8, 7, 8});
listaBandasRegistradas.Add("Skillet", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");

    Console.WriteLine(@"Bem vindo ao Screen Sound");
}

void Menu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para resgistrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair\n");

    Console.WriteLine("Digite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerico = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerico)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4:Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerico);
            break;
        case -1: Console.WriteLine("Programa encerrado");
            break;
        default: Console.WriteLine("Opação invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Banerfuncao("Registrar banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaBandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Console.WriteLine($"\nPrecione qualquer tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void MostrarBandas()
{
    Console.Clear();
    Banerfuncao("Lista bandas cadastradas");
 //   for (int i = 0; i < listaBandas.Count; i++)
 //   {
 //       Console.WriteLine($"Banda: {listaBandas[i]}");
 //   }
     foreach (var banda in listaBandasRegistradas.Keys)
     {
         Console.WriteLine($"Banda: {banda}");
     }
    Console.WriteLine("\nPrecione qualquer tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void Banerfuncao(string mensagem)
{
    string asteriscos = string.Empty.PadLeft(mensagem.Length, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(mensagem);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    //validar se a banda esta cadastrada
    Console.Clear();
    Banerfuncao("Avaliar banda");
    Console.WriteLine("Digite a banda que deseja valiar\n");
    string banda  = Console.ReadLine()!;
    if (listaBandasRegistradas.ContainsKey(banda))
    {
        Console.WriteLine($"Avalie a banda {banda}, com um valor de 1 a 10: ");
        int nota = int.Parse(Console.ReadLine()!);
        listaBandasRegistradas[banda].Add(nota);
        Console.WriteLine($"\nA banda {banda}, recebeu a nota {nota}");
        Thread.Sleep(4000);
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"A banda {banda} não esta registrada\n");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    
}
Menu();
