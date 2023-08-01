using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.Util;
public class ListAcconts
{
    private ContaCorrente[] _itens = null;
    private int _itensCount = 0;
    public ListAcconts(int startingSize=5)
    {
        _itens = new ContaCorrente[startingSize];
    }

    public void AddAccont(ContaCorrente accont)
    {
        Console.WriteLine($"Add item in {_itensCount} position");
        ValidateCapacity(_itensCount + 1);
        _itens[_itensCount] = accont;
        _itensCount++;
    }

    private void ValidateCapacity(int requiredSize)
    {
        if (_itens.Length > requiredSize)
        {
            return;
        }

        Console.WriteLine("Add list capacity");
        ContaCorrente[] newArray = new ContaCorrente[requiredSize];

        for (int i = 0; i < _itens.Length; i++)
        {
            newArray[i] = _itens[i];
        }
        _itens = newArray;
    }

    private ContaCorrente SearchAccountHigherBalance()
    {
        ContaCorrente higherBalance = null;
        double balance = 0;
        for (int i = 0; i < _itens.Length; i++)
        {
            if (_itens[i] != null)
            {
                if (balance < _itens[i].Saldo)
                {
                    balance = _itens[i].Saldo;
                    higherBalance = _itens[i];
                }
            }
        }

        return higherBalance;
    }

    public void DeleteAccont(ContaCorrente accont)
    {
        int _itemMenu = -1;
        for (int i = 0; i < _itensCount; i++)
        {
            ContaCorrente currentAccount = _itens[i];
            if (currentAccount == accont)
            {
                _itemMenu = i;
                break;
            }
        }

        for (int i = _itemMenu; i < _itensCount-1; i++)
        {
            _itens[i] = _itens[i + 1];
        }
        _itensCount--;
        _itens[_itensCount] = null;
    }

    public void ShowAcconts()
    {
        for (int i = 0; i < _itens.Length; i++)
        {
            if(_itens[i] != null) { Console.WriteLine($"Menu {i}: Agencia: {_itens[i].NumeroAgencia}, Conta: {_itens[i].Conta}"); }
            
        }

        Console.WriteLine("End list!!\n\n");
    }

    public ContaCorrente RecoverIndexAccount(int index)
    {
        if (index < 0 || index >= _itensCount)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        return _itens[index];
    }

    public int Size
    {
        get
        {
            return _itensCount;
        }
    }

    public ContaCorrente this[int index]
    {
        get { return RecoverIndexAccount(index); }
    }
}
