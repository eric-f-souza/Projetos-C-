using System.Collections;
using System.Collections.Specialized;
using System.Security.Principal;
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Modelos.Service;
using bytebank_ATENDIMENTO.bytebank.Util;
using bytebank_ATENDIMENTO.bytebankExceptions;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Ex Arrays
Array sample = Array.CreateInstance(typeof(double), 5);
sample.SetValue(5.9, 0);
sample.SetValue(1.9, 1);
sample.SetValue(7.1, 2);
sample.SetValue(10, 3);
sample.SetValue(6.9, 4);
//TestFindWords();
//TestMid(sample);
//simpleMedia(sample);
//TestObjectContaCorrente();
void ArraySimpleTest()
{
    int idade0 = 30;
    int idade1 = 30;
    int idade2 = 17;
    int idade3 = 21;
    int idade4 = 18;

    int[] idades = new int[5];

    idades[0] = idade0;
    idades[1] = idade1;
    idades[2] = idade2;
    idades[3] = idade3;
    idades[4] = idade4;

    Console.WriteLine($"Tamanho Array {idades.Length}");
    

}

void TestFindWords()
{
    string[] arrayWords = new string[5];

    for (int i = 0; i < arrayWords.Length; i++)
    {
        Console.WriteLine($"Digite {i+1}° palavra");
        arrayWords[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada:");
    var choiseWord = Console.ReadLine();

    foreach (var word in arrayWords)
    {
        if (word.Equals(choiseWord))
        {
            Console.WriteLine($"A palavra {word} esta na lista");
            break;
        }
        else
        {
            Console.WriteLine($"Palavra não encontrada");
        }
    }
}

double simpleMedia(Array array)
{
    if (array == null || (array.Length == 0))
    {
        Console.WriteLine("Array vazio");
    }

    double[] doubleArray = (double[])array.Clone();
    //var media =doubleArray.Average();
    double sumDouble = 0;
    for (int i = 0; i < doubleArray.Length; i++)
    {
        sumDouble += doubleArray[i];
    }

    return sumDouble / doubleArray.Length;
}

void TestMid(Array array)
{
    if (array == null || (array.Length == 0))
    {
        Console.WriteLine("Array vazio");
    }

    double[] ordenedNumbers = (double[])array.Clone();
    Array.Sort(ordenedNumbers);

    int sizeArray = ordenedNumbers.Length;
    int mid = sizeArray / 2;
    double midian = (sizeArray % 2 != 0) ? ordenedNumbers[mid] : (ordenedNumbers[mid - 1]) / 2;

    Console.WriteLine($"Mediana = {midian}");
}

//int[] values = { 10, 58, 36, 47 };
//for (int i = 0; i < values.Length; i++)
//{
//    Console.WriteLine(values[i]);
//}

void TestObjectContaCorrente()
{
    ListAcconts listContaCorrente = new ListAcconts();
    listContaCorrente.AddAccont(new ContaCorrente(874));
    listContaCorrente.AddAccont(new ContaCorrente(875));
    listContaCorrente.AddAccont(new ContaCorrente(876));
    listContaCorrente.AddAccont(new ContaCorrente(878));
    listContaCorrente.AddAccont(new ContaCorrente(879));
    listContaCorrente.AddAccont(new ContaCorrente(880));

    var testDeletAccont = new ContaCorrente(882);
    listContaCorrente.AddAccont(testDeletAccont);
    //listContaCorrente.ShowAcconts();

    //listContaCorrente.DeleteAccont(testDeletAccont);
    //listContaCorrente.ShowAcconts();

    for (int i = 0; i < listContaCorrente.Size; i++)
    {
        var accont = listContaCorrente[i];
        Console.WriteLine($"Index: {i}, Accont: {accont.Conta}, Agency: {accont.NumeroAgencia}");
    }
}
#endregion

#region List

bool SearchName(List<string> ChosenNames, string name)
{
    return ChosenNames.Contains(name);
}

//_listAccont.AddRange(_listAccont2);
//_listAccont.Reverse();

//_listAccont.ForEach(account => Console.Write($"Account {account.Conta}\n"));

//var range = _listAccont2.GetRange(0, 1);


#endregion


new BytebankService().ServiceClient();

